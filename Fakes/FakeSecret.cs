using System;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    internal class FakeSecret : Secret
    {
        private readonly string value;

        public FakeSecret(string identifier, string value, Store store, DateTime updated, string account, string url)
        {
            Identifier = identifier;
            this.value = value;
            Store = store;
            Updated = updated;
            Account = account ?? string.Empty;
            Url = url ?? string.Empty;
        }

        public override Task<string> GetValueAsync() => Task.FromResult(value);
    }
}
