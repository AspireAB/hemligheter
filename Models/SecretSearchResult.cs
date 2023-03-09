using Hemligheter.Services;

namespace Hemligheter
{
    public class SecretSearchResult
    {
        public Secret Secret { get; }
        public ResultType ResultType { get; }

        public SecretSearchResult(Secret secret, ResultType resultType)
        {
            Secret = secret;
            ResultType = resultType;
        }
    }
}