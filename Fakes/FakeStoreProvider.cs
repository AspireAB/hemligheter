using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    class FakeStoreProvider : IStoreProvider
    {
        private List<Store> _stores;

        public FakeStoreProvider()
        {
            _stores = new List<Store>
            {
                //new FakeStore{ Name = "SKAEJSYNAS",   Identifier="http://localhost", Permissions = StorePermissions.Read },

                new FakeStore("Test2-hopp","http://localhost", StorePermissions.List | StorePermissions.Read),
                new FakeStore("Test3-hopp","http://localhost", StorePermissions.List | StorePermissions.Write),
                new FakeStore("Test4-hej", "http://localhost", StorePermissions.List | StorePermissions.Delete),
                new FakeStore("Test5-hopp","http://localhost", StorePermissions.List | StorePermissions.Read | StorePermissions.Write),
                new FakeStore("Test6-hopp","http://localhost", StorePermissions.List | StorePermissions.Read | StorePermissions.Delete),
                new FakeStore("Test7-hej", "http://localhost", StorePermissions.List | StorePermissions.Delete | StorePermissions.Write),
                new FakeStore("Test8-hopp","http://localhost", StorePermissions.List | StorePermissions.Read | StorePermissions.Delete | StorePermissions.Write)
            };

            foreach (var store in _stores)
            {
                store.AddSecretAsync(new NewSecret("testhemlighet-1", "hemligtvärde1"));
                store.AddSecretAsync(new NewSecret("testhemlighet-2", "hemligtvärde2"));
            }
        }

        public async Task<IEnumerable<Store>> GetStores()
        {
            await Task.Delay(500);
            return _stores.AsEnumerable();
        }

        public Task<string> FindSecretValue(string url, string secretName)
        {
            return Task.FromResult("Lösen: " + secretName);
        }
    }
}
