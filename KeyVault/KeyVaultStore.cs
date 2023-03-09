using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.Azure.Management.KeyVault.Models;
using Microsoft.Rest.Azure;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    public class KeyVaultStore : Store
    {
        private readonly KeyVaultClient _keyVaultClient;

        public KeyVaultStore(KeyVaultClient keyVaultClient, Vault vault, AuthenticatedUser user)
        {
            Name = vault.Name;
            Identifier = vault.Properties.VaultUri;
            Permissions = MapAccessPoliciesToPermissions(vault.Properties.AccessPolicies, user);
            _keyVaultClient = keyVaultClient;
        }

        private static StorePermissions MapAccessPoliciesToPermissions(IEnumerable<AccessPolicyEntry> accessPolicies, AuthenticatedUser user)
        {
            var userAccessPolicies = accessPolicies
                .Where(policy => policy.ObjectId == user.UserId || user.IsMemberOf(policy.ObjectId))
                .SelectMany(policy => policy.Permissions.Secrets)
                .Distinct();

            StorePermissions permissions = StorePermissions.None;

            foreach (var policy in userAccessPolicies)
            {
                switch (policy)
                {
                    case "Get":
                        permissions |= StorePermissions.Read;
                        break;
                    case "List":
                        permissions |= StorePermissions.List;
                        break;
                    case "Set":
                        permissions |= StorePermissions.Write;
                        break;
                    case "Delete":
                        permissions |= StorePermissions.Delete;
                        break;
                }
            }

            return permissions;
        }

        public override async Task<bool> AddSecretAsync(NewSecret secret)
        {
            try
            {
                var tags = new Dictionary<string, string>();

                if (string.IsNullOrWhiteSpace(secret.Account) == false)
                {
                    tags.Add("Account", secret.Account);
                }

                if (string.IsNullOrWhiteSpace(secret.Url) == false)
                {
                    tags.Add("Url", secret.Url);
                }

                Log.Information("Adding secret...");
                await _keyVaultClient.SetSecretAsync(Identifier, secret.Name, secret.Value, tags);
                Log.Information("Secret added");

                return true;
            }
            catch (Exception e)
            {
                Log.Error(e, "An error occured while adding secret");
            }

            return false;
        }
        public override async Task<bool> DeleteSecretAsync(Secret secret)
        {
            try
            {
                Log.Information("Deleting secret...");
                await _keyVaultClient.DeleteSecretAsync(Identifier, secret.Identifier);
                Log.Information("Secret deleted");

                return true;
            }
            catch (Exception e)
            {
                Log.Error(e, "An error occured while deleting secret");
            }

            return false;
        }

        public override async Task<IEnumerable<Secret>> GetSecretsAsync()
        {
            Log.Information("Loading secrets from a store...");
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var firstPage = await _keyVaultClient.GetSecretsAsync(Identifier);
            var secretItems = await GetSecretsFromPageRecursive(firstPage);

            stopwatch.Stop();
            Log.Information("Found {0} secrets in a store in {2} ms", secretItems.Count, stopwatch.ElapsedMilliseconds);

            return secretItems.Select(s => new KeyVaultSecret(_keyVaultClient, s, this));
        }

        private async Task<List<SecretItem>> GetSecretsFromPageRecursive(IPage<SecretItem> page)
        {
            var secrets = page.ToList();

            if (string.IsNullOrWhiteSpace(page.NextPageLink))
                return secrets;

            var nextPage = await _keyVaultClient.GetSecretsNextAsync(page.NextPageLink);
            return secrets.Concat(await GetSecretsFromPageRecursive(nextPage)).ToList();
        }
    }
}