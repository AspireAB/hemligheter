using System;
using System.Web.Security;

namespace Hemligheter.Helpers
{
    internal class PasswordHelper
    {
        internal string GeneratePassword()
        {
            return Membership.GeneratePassword(16, 6);
        }
    }
}