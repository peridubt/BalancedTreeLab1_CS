using BalacnedTree;
using System.Collections;
using System.Net;

namespace BalancedTreeLab
{
    public class LinkedTree<T> : ITree<T> where T : IComparable<T>
    {
        private Node<T> root = null;

        private List<Node<T>> list = new List<Node<T>>();
        public int Count { get => list.Count;}
        public bool IsEmpty { get => Count == 0; }
        public IEnumerable<Node<T>> Nodes { get => list; set => Nodes = value; }

        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>)Nodes.GetEnumerator();

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

        private Node<T> RotateLeft(Node<T> node) // левый поворот вокруг q
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
                list.Add(newNode);
                return newNode;
            }
            if (data.CompareTo(node.Data) < 0)
                node.Left = AddToRoot(node.Left, data);
            else
                node.Right = AddToRoot(node.Right, data);
            return Balance(node);
        }

        private void SwapRoot()
        {
            for (int i = 0; i < Count; ++i)
            {
                if (list[i].Equals(root))
                    (list[i], list[0]) = (list[0], list[i]);
            }
        }

        public void Add(T data)  
        {
            root = AddToRoot(root, data);
            SwapRoot();
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

        void DelFromList(T data)
        {
            for (int i = 0; i < Count; ++i)
                if (list[i].Data.Equals(data))
                    list.RemoveAt(i);
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
                DelFromList(data);
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
            root = RemoveFromRoot(root, data);
            SwapRoot();
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
            list.Clear();
            ClearRec(root);
        }
    }
}
