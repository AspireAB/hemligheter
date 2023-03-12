using Azure.Security.KeyVault.Secrets;
using System;
using System.Linq;

namespace Hemligheter.Data
{
    public static class NodeExtensions
    {
        public static DateTimeOffset UpdatedOn(this Node<SecretProperties> node)
        {
            return new[] { node.Nodes.Max(node => node.UpdatedOn() as DateTimeOffset?) ?? DateTimeOffset.MinValue, node.Leaves.Max(leaf => leaf.Value.UpdatedOn) ?? DateTimeOffset.MinValue }.Max();
        }
    }
}
