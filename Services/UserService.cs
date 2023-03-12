using Azure.Core;
using Azure.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hemligheter.Services
{
    public class UserService
    {
        private readonly DefaultAzureCredential credential;
        private AccessToken token;

        public TokenCredential Credential => credential;

        public UserService()
        {
            credential = new DefaultAzureCredential(includeInteractiveCredentials: true);
        }

        public async Task<AuthenticatedUser> GetUserAsync(CancellationToken cancellationToken = default)
        {
            if (token.Equals(default(AccessToken)) || token.ExpiresOn < DateTimeOffset.Now)
            {
                token = await credential.GetTokenAsync(new TokenRequestContext(new[] { "https://vault.azure.net/.default" }), cancellationToken);
            }

            var user = new AuthenticatedUser(token.Token);
            return user;
        }
    }
}
