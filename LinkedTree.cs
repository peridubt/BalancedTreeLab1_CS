using BalacnedTree;
using System.Collections;

namespace BalancedTreeLab
{
    public class LinkedTree<T> : ITree<T> where T : IComparable<T>
    {
        private Node<T> root = null;

        private LinkedList<Node<T>> list = new LinkedList<Node<T>>();
        public int Count { get; set; }
        public bool IsEmpty { get => Count == 0; }
        public IEnumerable<Node<T>> Nodes { get => list; set => Nodes = value; }

        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>)Nodes.GetEnumerator();

        public LinkedTree() { }

        private void BalancedAdd(int count, ref Node<T> node, T data)
        {
            if (count != 0)
            {
                int count_left = count / 2;
                int count_right = count - count_left - 1;
                if (node == null)
                {
                    node = new Node<T>(data);
                    list.AddLast(node);
                    return;
                }
                BalancedAdd(count_left, ref node.left, data);
                BalancedAdd(count_right, ref node.right, data);
            }
        }

        public void Add(T node)
        {
            Count++;
            if (root == null)
            {
                root = new Node<T>(node);
                list.AddLast(root);
                return;
            }
            BalancedAdd(Count, ref root, node);
        }

        Node<T> FindFirstEntry(T data)
        {
            foreach (var elem in list)
                if (elem.Data.Equals(data))
                    return elem;
            return null;
        }

        public void Remove(T node)
        {
            if (root == null)
                throw new TreeElementRemovalDenial("Cannot remove node from empty tree");
            if (node == null || !Contains(node))
                throw new TreeElementRemovalDenial("Cannot remove a non-existent element");

            /*list.Remove(FindFirstEntry(node));
            IEnumerator<Node<T>> enumerator = list.GetEnumerator();
            enumerator.MoveNext();
            list.RemoveFirst(); list.AddFirst(root);
            Count--;*/
        }

        public bool Contains(T node)
        {
            foreach (var elem in Nodes)
            {
                if (elem.Data.Equals(node))
                    return true;
            }
            return false;
        }

        private void ClearRec(Node<T> node)
        {
            if (node != null)
            {
                ClearRec(node.left);
                ClearRec(node.right);
                node = null;
            }
        }

        public void Clear()
        {
            if (IsEmpty)
                throw new TreeModificationDenial("Cannot clear an empty tree");
            ClearRec(root);
        }
    }
}
