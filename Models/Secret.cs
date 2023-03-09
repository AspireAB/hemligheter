using System;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    public abstract class Secret
    {
        public string Identifier { get; protected set; }
        public string Account { get; protected set; }
        public string Url { get; protected set; }
        public Store Store { get; protected set; }
        public DateTime? Updated { get; protected set; }
        public string Name => $"{Store.Name}-{Identifier}";
        public bool HasMetadata => string.IsNullOrWhiteSpace(Account + Url) == false;

        public bool CanRead => Store.Permissions.HasFlag(StorePermissions.Read);
        public bool CanEdit => Store.Permissions.HasFlag(StorePermissions.Write);
        public bool CanDelete => Store.Permissions.HasFlag(StorePermissions.Delete);

        public abstract Task<string> GetValueAsync();
        public Task<bool> DeleteAsync() => Store.DeleteSecretAsync(this);

    }
}