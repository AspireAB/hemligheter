using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json.Linq;

namespace Hemligheter.Services
{
    public class AuthenticatedUser
    {
        public string UserId { get; }
        public List<string> GroupIds { get; }
        public string AccessToken { get; set; }

        public AuthenticatedUser(AuthenticationResult authenticationResult)
        {
            UserId = authenticationResult.UserInfo.UniqueId;
            GroupIds = GetGroupsFromToken(authenticationResult);
            AccessToken = authenticationResult.AccessToken;
        }

        private List<string> GetGroupsFromToken(AuthenticationResult result)
        {
            var jwtToken = new JwtSecurityToken(result.AccessToken);

            if (jwtToken.Payload.TryGetValue("groups", out var groupObject) && groupObject is JArray)
            {
                return ((JArray)groupObject).Values<string>().ToList();
            }

            return new List<string>();
        }

        public bool IsMemberOf(string groupObjectId)
        {
            return GroupIds.Contains(groupObjectId);
        }
    }
}