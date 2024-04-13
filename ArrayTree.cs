using BalacnedTree;
using System.Collections;

namespace BalancedTreeLab
{
    public class ArrayTree<T> : ITree<T> where T : IComparable<T>
    {
        private Node<T>[] arr;
        private int capacity;
        public int Count { get; set; }
        public bool IsEmpty { get => Count == 0; }
        public IEnumerable<Node<T>> Nodes
        {
            get
            {
                if (IsEmpty)
                    throw new TreeException("Cannot traverse an empty tree");
                return ArrTraversal();
            }
            set => Nodes = value;
        }

        public IEnumerable<Node<T>> ArrTraversal()
        {
            if (arr[0] == null)
                yield break;

            for (int i = 0; i < capacity; ++i)
                if (arr[i] != null)
                    yield return arr[i];
        }

        public IEnumerator<Node<T>> GetEnumerator() => ArrTraversal().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Nodes.GetEnumerator();

        private int levels = 0;
        private int LeftChildIndex(int i) => 2 * i + 1;
        private int RightChildIndex(int i) => 2 * i + 2;

        private bool HasLeftChild(int i) => 2 * i + 1 < capacity;
        private bool HasRightChild(int i) => 2 * i + 2 < capacity;

        public ArrayTree()
        {
            Count = 0;
            capacity = 1;
            arr = new Node<T>[capacity];
        }

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
                return newNode;
            }
            if (data.CompareTo(node.Data) < 0)
                node.Left = AddToRoot(node.Left, data);
            else
                node.Right = AddToRoot(node.Right, data);
            return Balance(node);
        }

        private void RearrangeArr(Node<T> node, int i)
        {
            if (node != null && i < capacity)
            {
                if (node.Left != null && HasLeftChild(i))
                    arr[LeftChildIndex(i)] = node.Left;
                if (node.Right != null && HasRightChild(i))
                    arr[RightChildIndex(i)] = node.Right;
                RearrangeArr(node.Left, LeftChildIndex(i));
                RearrangeArr(node.Right, RightChildIndex(i));
            }
        }

        public void Add(T data)
        {
            if (!IsEmpty && Contains(data))
                throw new TreeModificationDenial("Element is already in tree");
            if (Count == capacity)
            {
                levels++;
                capacity += (int)Math.Pow(2, levels);
                Node<T>[] newArray = new Node<T>[capacity];
                arr.CopyTo(newArray, 0);
                arr = newArray;
            }
            Count++;
            if (Count > 1)
                Array.Clear(arr, 1, capacity - 1);
            arr[0] = AddToRoot(arr[0], data);
            RearrangeArr(arr[0], 0);

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
            Count--;
            if (Count > 1)
                Array.Clear(arr, 1, capacity - 1);
            arr[0] = RemoveFromRoot(arr[0], data);
            RearrangeArr(arr[0], 0);
        }

        public bool Contains(T data)
        {
            foreach (var elem in Nodes)
            {
                if (elem.Data.CompareTo(data) == 0)
                    return true;
            }
            return false;
        }

        public void Clear()
        {
            if (IsEmpty)
                throw new TreeModificationDenial("Cannot clear an empty tree");
            Array.Clear(arr, 0, capacity);
            Count = 0;
        }
    }
}
