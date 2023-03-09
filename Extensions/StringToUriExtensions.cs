using System;

namespace Hemligheter.Extensions
{
    public static class StringToUriExtensions
    {
        public static Uri ToVerifiedUri(this string indata, string uriScheme)
        {
            string text = indata.Trim(' ', '\n', '\r', '\t');

            if (text.Length > (uriScheme + "://").Length)
            {
                if (Uri.TryCreate(text, UriKind.Absolute, out Uri uri) && uri.Scheme == uriScheme)
                {
                    return uri;
                }
            }

            return null;
        }
    }
}
