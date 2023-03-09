using System;

namespace Hemligheter.Services
{
    internal class AuthenticationException : Exception
    {
        public AuthenticationException(string message) : base(message)
        {
        }
    }
}