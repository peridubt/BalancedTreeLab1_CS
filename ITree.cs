using BalancedTreeLab;

namespace BalacnedTree
{
    public interface ITree<T> : IEnumerable<Node<T>> where T : IComparable<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        IEnumerable<Node<T>> Nodes { get; set; }

        void Add(T node);
        void Clear();
        bool Contains(T node);
        void Remove(T node);
    }
}
