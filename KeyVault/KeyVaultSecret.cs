using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.Models;
using Serilog;
using System;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    public class KeyVaultSecret : Secret
    {
        private readonly KeyVaultClient keyVaultClient;

        public KeyVaultSecret(KeyVaultClient keyVaultClient, SecretItem secretItem, Store store)
        {
            this.keyVaultClient = keyVaultClient;

            Identifier = secretItem.Identifier.Name;
            Updated = secretItem.Attributes.Updated;
            Store = store;
            Account = string.Empty;
            Url = string.Empty;

            if (secretItem.Tags != null)
            {
                if (secretItem.Tags.ContainsKey("Account"))
                {
                    Account = secretItem.Tags["Account"];
                }

                if (secretItem.Tags.ContainsKey("Url"))
                {
                    Url = secretItem.Tags["Url"];
                }
            }
        }

        public override async Task<string> GetValueAsync()
        {
            try
            {
                var secretBundle = await keyVaultClient.GetSecretAsync(Store.Identifier, Identifier);
                return secretBundle?.Value;
            }
            catch (Exception e)
            {
                Log.Error(e, "An error occured while getting secret value");
                return string.Empty;
            }
        }
    }
}