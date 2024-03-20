using BalacnedTree;
using System.Collections;
using System.Collections.Generic;

namespace BalancedTreeLab
{
    public class ArrayTree<T> : ITree<T> where T : IComparable<T>
    {
        private Node<T>[] arr;
        private int capacity;
        public int Count { get; set; }
        public bool IsEmpty { get => Count == 0; }
        public IEnumerable<Node<T>> Nodes { get => arr; set => Nodes = value; }

        private int levels = 0;
        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;

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
                if (node.Left != null && GetLeftChildIndex(i) < capacity)
                    arr[GetLeftChildIndex(i)] = node.Left;
                if (node.Right != null && GetRightChildIndex(i) < capacity)
                    arr[GetRightChildIndex(i)] = node.Right;
                RearrangeArr(node.Left, 2 * i + 1);
                RearrangeArr(node.Right, 2 * i + 2);
            }
        }

        public void Add(T data)
        {
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
            Count--;
            if (Count > 1)
                Array.Clear(arr, 1, capacity - 1);
            arr[0] = RemoveFromRoot(arr[0], data);
            RearrangeArr(arr[0], 0);
        }

        public bool Contains(T node)
        {
            foreach (var elem in Nodes)
            {
                if (elem != null)
                    if (elem.Data.Equals(node))
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

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)Nodes.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Nodes.GetEnumerator();
        }
    }
}
