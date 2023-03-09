using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    public interface IStoreProvider
    {
        Task<IEnumerable<Store>> GetStores();
        Task<string> FindSecretValue(string secretName, string store);
    }
}