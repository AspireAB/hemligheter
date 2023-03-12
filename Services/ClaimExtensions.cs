using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Hemligheter.Services
{
    public static class ClaimExtensions
    {
        public static string FindOne(this IEnumerable<Claim> claims, string claimType)
        {
            return claims.FirstOrDefault(c => c.Type == claimType)?.Value;
        }
        public static IEnumerable<string> FindAll(this IEnumerable<Claim> claims, string claimType)
        {
            return claims.Where(c => c.Type == claimType).Select(c => c.Value);
        }
    }
}
