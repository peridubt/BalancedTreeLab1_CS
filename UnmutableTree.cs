using BalacnedTree;
using System.Collections;

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

        public void Add(T node)
        {
            throw new TreeModificationDenial("This tree cannot be modified");
        }

        public void Clear()
        {
            throw new TreeModificationDenial("This tree cannot be modified");
        }

        public bool Contains(T node)
        {
            throw new TreeModificationDenial("This tree cannot be modified");
        }

        public void Remove(T node)
        {
            throw new TreeModificationDenial("This tree cannot be modified");
        }

        public IEnumerator<Node<T>> GetEnumerator() => Nodes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
