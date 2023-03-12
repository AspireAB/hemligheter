using System;
using System.Collections.Generic;
using System.Linq;

namespace Hemligheter.Data
{
    public class Node<T>
    {
        public string Name { get; }
        public string Path { get; }
        public Node<T> Parent { get; }
        public IReadOnlyList<Node<T>> Parents { get; }
        public List<Leaf<T>> Leaves { get; }
        public List<Node<T>> Nodes { get; }
        public bool Expanded { get; set; }

        public Node(string name, Node<T> parent = null, List<Node<T>> values = null)
        {
            Name = name;
            Parent = parent;
            var parents = parent?.Parents.ToList() ?? new List<Node<T>>();
            if (parent != null)
            {
                parents.Insert(0, parent);
                Path = $"{(parent.Path is not null ? $"{parent.Path}-" : string.Empty)}{parent.Name}";
            }
            Parents = parents;
            Leaves = new List<Leaf<T>>();
            Nodes = values ?? new List<Node<T>>();
        }
    }

    public class Leaf<T>
    {
        public string Name { get; }
        public T Value { get; }

        public Leaf(string name, T value)
        {
            Name = name;
            Value = value;
        }
    }
}
