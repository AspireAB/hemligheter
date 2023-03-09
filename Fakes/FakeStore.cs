using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    public class FakeStore : Store
    {
        private readonly List<Secret> secrets;

        public FakeStore(string name, string identifier, StorePermissions storePermissions)
        {
            Name = name;
            Identifier = identifier;
            Permissions = storePermissions;

            secrets = new List<Secret>();
        }

        public override Task<bool> AddSecretAsync(NewSecret secret)
        {
            var existingSecret = secrets.SingleOrDefault(s => s.Identifier == secret.Name);
            if (existingSecret != null)
                secrets.Remove(existingSecret);

            secrets.Add(new FakeSecret(secret.Name, secret.Value, this, DateTime.Now, secret.Account, secret.Url));
            return Task.FromResult(true);
        }

        public override Task<bool> DeleteSecretAsync(Secret secret)
        {
            secrets.Remove(secret);
            return Task.FromResult(true);
        }

        public async override Task<IEnumerable<Secret>> GetSecretsAsync()
        {
            await Task.Delay(1500);
            return secrets.AsEnumerable();
        }
    }
}