using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.KeyVault;
using Azure.ResourceManager.KeyVault.Models;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    public class KeyVaultService
    {
        private readonly UserService userService;

        public KeyVaultService(UserService userService)
        {
            this.userService = userService;
        }

        public async Task<IEnumerable<Tuple<Vault, Azure.Security.KeyVault.Secrets.SecretProperties>>> GetSecretsAsync(CancellationToken cancellationToken = default, IProgress<string> progress = null) 
        {
            progress?.Report("user");
            var user = await userService.GetUserAsync(cancellationToken);

            progress?.Report("vault settings");
            var armClient = await Task.Run(() =>
            {
                return new ArmClient(userService.Credential);
            }, cancellationToken);

            var secrets = new ConcurrentBag<Tuple<Vault, Azure.Security.KeyVault.Secrets.SecretProperties>>();
            var options = new ParallelOptions { MaxDegreeOfParallelism = 15 };
            var sw = Stopwatch.StartNew();

            await Parallel.ForEachAsync(armClient.GetSubscriptions().GetAllAsync(cancellationToken), options, async (subscription, ct1) =>
            {
                progress?.Report(subscription.Data.SubscriptionId);
                await Parallel.ForEachAsync(subscription.GetVaultsAsync(cancellationToken: ct1), options, async (vault, ct2) =>
                {
                    progress?.Report(vault.Data.Name);
                    var accessPolicies = vault.Data.Properties.AccessPolicies;
                    var permissions = accessPolicies
                        .Where(policy => policy.ObjectId == user.UserId || user.IsMemberOf(policy.ObjectId))
                        .SelectMany(policy => policy.Permissions.Secrets)
                        .Distinct();

                    var canListSecrets = permissions.Contains(SecretPermissions.List);
                    if (canListSecrets)
                    {
                        var client = new SecretClient(new Uri(vault.Data.Properties.VaultUri), userService.Credential);
                        await foreach (var secret in client.GetPropertiesOfSecretsAsync(ct2))
                        {
                            progress?.Report(secret.Name);
                            secrets.Add(new Tuple<Vault, Azure.Security.KeyVault.Secrets.SecretProperties>(vault, secret));
                        }
                    }
                });
            });

            sw.Stop();

            return secrets.OrderBy(s => s.Item2.Name).ToList();
        }

        public async Task<string> GetSecretValueAsync(Azure.Security.KeyVault.Secrets.SecretProperties secretProperties)
        {
            var client = new SecretClient(secretProperties.VaultUri, userService.Credential);
            var secret = await client.GetSecretAsync(secretProperties.Name);

            return secret.Value.Value;
        }
    }
}
