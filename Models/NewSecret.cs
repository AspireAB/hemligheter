namespace Hemligheter.Services
{
    public class NewSecret
    {
        public string Name { get; }
        public string Value { get; }
        public string Account { get; }
        public string Url { get; }

        public NewSecret(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public NewSecret(string name, string value, string account, string url) : this(name, value)
        {
            Account = account;
            Url = url;
        }

        public bool IsValid() => string.IsNullOrWhiteSpace(Name) == false
            && string.IsNullOrWhiteSpace(Value) == false;
    }
}