using BalacnedTree;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BalancedTreeLab
{
    public class UnmutableTree<T> : ITree<T> where T : IComparable<T>
    {
        private ITree<T> tree;

        public UnmutableTree() { }

        public UnmutableTree(ITree<T> tree) { this.tree = tree; }

        public int Count { get => tree.Count; }

        public bool IsEmpty { get => tree.IsEmpty; }

        public IEnumerable<Node<T>> Nodes { get => tree.Nodes; set => throw new TreeModificationDenial("This tree cannot be modified!"); }

        public void Add(T data)
        {
            throw new TreeModificationDenial("This tree cannot be modified");
        }

        public void Clear()
        {
            throw new TreeModificationDenial("This tree cannot be modified");
        }

        public bool Contains(T data)
        {
            foreach (var elem in Nodes)
            {
                if (elem.Data.CompareTo(node) == 0)
                    return true;
            }
            return false;
        }

        public void Remove(T data)
        {
            throw new TreeModificationDenial("This tree cannot be modified");
        }

        public IEnumerator<Node<T>> GetEnumerator() => Nodes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
