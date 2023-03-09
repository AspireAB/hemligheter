using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    public abstract class Store
    {
        public string Name { get; protected set; }
        public string Identifier { get; protected set; }
        public StorePermissions Permissions { get; protected set; }

        public abstract Task<IEnumerable<Secret>> GetSecretsAsync();
        public abstract Task<bool> AddSecretAsync(NewSecret newSecret);
        public abstract Task<bool> DeleteSecretAsync(Secret secret);
    }
}