using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Hemligheter.Services
{
    public static class ClaimConstants
    {
        public const string UserId = "oid";

        public const string Groups = "groups";

        public const string GivenName = "given_name";
        public const string LastName = "last_name";
        public const string FullName = "name";
    }

    public class AuthenticatedUser
    {
        private readonly JwtSecurityToken _jwtToken;

        public string UserId { get => _jwtToken.Claims.FindOne(ClaimConstants.UserId); }
        public string GivenName { get => _jwtToken.Claims.FindOne(ClaimConstants.GivenName); }
        public string LastName { get => _jwtToken.Claims.FindOne(ClaimConstants.LastName); }
        public string FullName { get => _jwtToken.Claims.FindOne(ClaimConstants.FullName); }
        public IEnumerable<string> GroupIds { get => _jwtToken.Claims.FindAll(ClaimConstants.Groups); }
        
        public AuthenticatedUser(string token)
        {
            _jwtToken = new JwtSecurityToken(token);
        }

        public bool IsMemberOf(string groupObjectId)
        {
            return GroupIds.Contains(groupObjectId);
        }
    }
}
