using BalacnedTree;
using System.Collections;

namespace BalancedTreeLab
{
    public class LinkedTree<T> : ITree<T> where T : IComparable<T>
    {
        private Node<T> root = null;
        public int Count { get; set; }
        public bool IsEmpty { get => Count == 0; }
        public IEnumerable<Node<T>> Nodes
        {
            get
            {
                if (IsEmpty)
                    throw new TreeException("Cannot traverse an empty tree");
                return DepthTraversal();
            }
            set => Nodes = value;
        }

        public IEnumerable<Node<T>> DepthTraversal()
        {
            if (root == null)
                yield break;

            var queue = new MyQueue<Node<T>>();
            queue.Enqueue(root);
            Node<T> node;
            while (!queue.Empty())
            {
                node = queue.Peek();
                queue.Dequeue();
                yield return node;

                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => Nodes.GetEnumerator();
        public IEnumerator<Node<T>> GetEnumerator() => DepthTraversal().GetEnumerator();

        public LinkedTree() { }

        private int GetHeight(Node<T> node)
        {
            return node != null ? node.Height : 0;
        }

        private int BalanceFactor(Node<T> node)
        {
            return GetHeight(node.Right) - GetHeight(node.Left);
        }

        private void FixHeight(Node<T> node)
        {
            int hLeft = GetHeight(node.Left);
            int hRight = GetHeight(node.Right);
            node.Height = (hLeft > hRight ? hLeft : hRight) + 1;
        }

        private Node<T> RotateRight(Node<T> node)
        {
            Node<T> t = node.Left;
            node.Left = t.Right;
            t.Right = node;
            FixHeight(node);
            FixHeight(t);
            return t;
        }

        private Node<T> RotateLeft(Node<T> node)
        {
            Node<T> t = node.Right;
            node.Right = t.Left;
            t.Left = node;
            FixHeight(node);
            FixHeight(t);
            return t;
        }

        private Node<T> Balance(Node<T> node)
        {
            FixHeight(node);
            if (BalanceFactor(node) == 2)
            {
                if (BalanceFactor(node.Right) < 0)
                    node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }
            if (BalanceFactor(node) == -2)
            {
                if (BalanceFactor(node.Right) > 0)
                    node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }
            return node;
        }

        private Node<T> AddToRoot(Node<T> node, T data)
        {
            if (node == null)
            {
                Node<T> newNode = new Node<T>(data);
                Count++;
                return newNode;
            }
            if (data.CompareTo(node.Data) < 0)
                node.Left = AddToRoot(node.Left, data);
            else
                node.Right = AddToRoot(node.Right, data);
            return Balance(node);
        }

        public void Add(T data)
        {
            root = AddToRoot(root, data);
        }

        Node<T> FindMin(Node<T> node)
        {
            return node.Left != null ? FindMin(node.Left) : node;
        }

        Node<T> RemoveMin(Node<T> node)
        {
            if (node.Left == null)
                return node.Right;
            node.Left = RemoveMin(node.Left);
            return Balance(node);
        }

        Node<T> RemoveFromRoot(Node<T> node, T data)
        {
            if (node == null)
                return null;
            if (data.CompareTo(node.Data) < 0)
                node.Left = RemoveFromRoot(node.Left, data);
            else if (data.CompareTo(node.Data) > 0)
                node.Right = RemoveFromRoot(node.Right, data);
            else
            {
                Node<T> p = node.Left;
                Node<T> q = node.Right;
                node = null;
                if (q == null)
                    return p;
                Node<T> min = FindMin(q);
                min.Right = RemoveMin(q);
                min.Left = p;
                return Balance(min);
            }
            return Balance(node);
        }

        public void Remove(T data)
        {
            if (IsEmpty)
                throw new TreeElementRemovalDenial("Cannot remove element from an empty tree");
            if (data == null || !Contains(data))
                throw new TreeElementRemovalDenial("Cannot remove a non-existent element");
            root = RemoveFromRoot(root, data);
        }

        public bool Contains(T data)
        {
            foreach (var elem in Nodes)
            {
                if (elem.Data.Equals(data))
                    return true;
            }
            return false;
        }

        private void ClearRec(Node<T> node)
        {
            if (node != null)
            {
                ClearRec(node.Left);
                ClearRec(node.Right);
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
