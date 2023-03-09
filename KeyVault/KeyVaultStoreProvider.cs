using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Management.KeyVault;
using Microsoft.Azure.Management.KeyVault.Models;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using Microsoft.Rest.Azure;
using Serilog;

namespace Hemligheter.Services
{
    class KeyVaultStoreProvider : IStoreProvider
    {
        private const string AppId = "d7813711-9094-4ad3-a062-cac3ec74ebe8";

        private readonly SettingsService _settingsService;
        private readonly KeyVaultClient _keyVaultClient;

        public KeyVaultStoreProvider(SettingsService settingsService)
        {
            _settingsService = settingsService;
            _keyVaultClient = CreateKeyVaultClient();
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            try
            {
                return await LoadStores();
            }
            catch(Exception e)
            {
                Log.Error(e, "An error occured while loading stores");
                return new List<Store>();
            }
        }

        public async Task<string> FindSecretValue(string secretName, string store)
        {
            try
            {
                var secretBundle = await _keyVaultClient.GetSecretAsync(store, secretName);
                return secretBundle?.Value;
            }
            catch (Exception e)
            {
                Log.Error(e, "An error occured while getting secret value");
                return string.Empty;
            }
        }

        private async Task<List<Store>> LoadStores()
        {
            Log.Information("Loading stores...");
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var settings = _settingsService.GetSettings();

            var storesCollection = await Task.WhenAll(settings.Authorities.Select(async authority =>
            {
                var user = await AuthenticateUser(authority, settings.Resource, string.Empty);
                var tokenCredentials = new TokenCredentials(user.AccessToken);

                SubscriptionClient subscriptionClient = new SubscriptionClient(tokenCredentials);
                var subscriptions = await subscriptionClient.Subscriptions.ListAsync();
                var enabledSubscriptions = subscriptions.Where(s => s.State == SubscriptionState.Enabled);

                return await Task.WhenAll(enabledSubscriptions.Select(async subscription =>
                {
                    Log.Information("Loading stores from a subscription...");
                    var sw = new Stopwatch();
                    sw.Start();

                    var keyVaultClient = new KeyVaultManagementClient(tokenCredentials)
                    {
                        SubscriptionId = subscription.SubscriptionId
                    };

                    var response = await GetAllVaults(keyVaultClient.Vaults);

                    var storeList = response
                        .Select(vault => new KeyVaultStore(_keyVaultClient, vault, user))
                        .Where(store => store.Permissions.HasFlag(StorePermissions.List))
                        .ToList();

                    sw.Stop();
                    Log.Information("Found {0} stores in a subscription in {2} ms", storeList.Count, sw.ElapsedMilliseconds);

                    return storeList;
                }));
            }));

            var stores = storesCollection.SelectMany(s1 => s1.SelectMany(s2 => s2)).ToList();

            stopwatch.Stop();
            Log.Information("Found {0} stores in {1} ms", stores.Count, stopwatch.ElapsedMilliseconds);

            return stores.OrderBy(v => v.Name).ToList<Store>();
        }

        private KeyVaultClient CreateKeyVaultClient()
        {
            var authenticationCallback = new KeyVaultClient.AuthenticationCallback(AuthenticationCallbackTarget);
            var httpClient = new HttpClient();
            return new KeyVaultClient(authenticationCallback, httpClient);
        }

        private static async Task<List<Vault>> FetchVaults(IVaultsOperations vaultsOperations, IPage<Vault> page)
        {
            if (string.IsNullOrWhiteSpace(page.NextPageLink))
                return page.ToList();

            var nextPage = await vaultsOperations.ListBySubscriptionNextAsync(page.NextPageLink);
            return page.ToList().Concat(await FetchVaults(vaultsOperations, nextPage)).ToList();
        }

        private static async Task<List<Vault>> GetAllVaults(IVaultsOperations vaultsOperations)
        {
            var page = await vaultsOperations.ListBySubscriptionAsync(1000);
            return await FetchVaults(vaultsOperations, page);
        }

        private static async Task<AuthenticatedUser> AuthenticateUser(string authority, string resource, string scope)
        {
            var context = new AuthenticationContext(authority);

            AuthenticationResult result;
            try
            {
                // Try to get the token from Windows auth
                result = await context.AcquireTokenAsync(resource, AppId, new UserCredential());
            }
            catch (Exception ex) // Multiple causes for failure. No need to catch specific error since we got backup.
            {
                var authEx = new AuthenticationExceptionFactory();
                authEx.Add(ex);
                var magicUri = new Uri("urn:ietf:wg:oauth:2.0:oob");
                try
                {
                    // Try to get the token silently, either using the token cache or browser cookies.
                    result = await context.AcquireTokenAsync(resource, AppId, magicUri, new PlatformParameters(PromptBehavior.Never));
                }
                catch (Exception ex2
                ) // Multiple causes for failure. No need to catch specific error since we got backup.
                {
                    authEx.Add(ex2);
                    try
                    {
                        // OK, ultimately fail: ask the user to authenticate manually.
                        result = await context.AcquireTokenAsync(resource, AppId, magicUri, new PlatformParameters(PromptBehavior.Always));
                    }
                    catch (Exception ex3)
                    {
                        authEx.Add(ex3);
                        throw authEx.Build(authority, resource);
                    }
                }
            }

            return new AuthenticatedUser(result);
        }

        private static async Task<string> AuthenticationCallbackTarget(string authority, string resource, string scope)
        {
            var user = await AuthenticateUser(authority, resource, scope);
            return user.AccessToken;
        }
    }
}
