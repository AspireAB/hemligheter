using System;
using System.Collections.Generic;

namespace Hemligheter.Services
{
    internal class AuthenticationExceptionFactory
    {
        private readonly List<string> _messages = new List<string>();
        public void Add(Exception ex)
        {
            _messages.Add(ex.Message);
            if (ex.InnerException != null)
                Add(ex.InnerException);
        }

        public AuthenticationException Build(string authority, string resource)
        {
            var exMessages = string.Join(", ", _messages);
            var message = $"Failed to authenticate to {authority} against {resource}. These failed attempts were " +
                          $"ultimately to munch: {exMessages}";
            return new AuthenticationException(message);
        }
    }
}