using BalacnedTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void SwitchNodes()
        {
            int border = capacity - (int)Math.Pow(2, levels);

            for (int i = 0; i < border; ++i)
            {
                arr[i].left = arr[GetLeftChildIndex(i)];
                arr[i].right = arr[GetRightChildIndex(i)];
            }
            for (int i = border; i < capacity; ++i)
            {
                if (arr[i] != null)
                {
                    arr[i].left = null;
                    arr[i].right = null;
                }
            }
        }

        private bool BalanacedAdd(Node<T> node, bool addLeft)
        {
            int i = (int)Math.Pow(2, levels) - 1; // индекс первого элемента в самом последнем ярусе дерева
            i = addLeft ? i : i + 1; // если мы пытаемся вставить вправо, то сдвигаемся на 1
            int differ = (int)Math.Pow(2, levels - 1); // разница в индексах между элементами разных поддеревьев
            int step = 2; // сдвигаемся каждый раз, останавливаясь либо только на левых потомках, либо только на правых
            while (i < capacity)
            {
                if (arr[i] == null)
                {
                    arr[i] = node;
                    return true;
                }
                else if (i + differ < capacity)
                {
                    if (arr[i + differ] == null)
                    {
                        arr[i + differ] = node;
                        return true;
                    }
                }
                i += step;
            }
            return false;
        }

        public void Add(T node)
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
            Node<T> newNode = new Node<T>(node);
            if (!BalanacedAdd(newNode, true))
                BalanacedAdd(newNode, false);
            SwitchNodes();
        }

        // удаление сделать сначала по правым потомкам, затем по левым
        // после всего этого, сделать перебалансировку дерева

        private void DeleteFromArray(T node)
        {
            int new_i = 0;
            for (int i = capacity - 1; i >= 0; i--)
            {
                if (arr[i] == null || !arr[i].Data.Equals(node))
                {
                    arr[new_i] = arr[i];
                    new_i++;
                }
                i++;
            }
        }

        private void RearrangeTree(int count, int i, MyQueue<Node<T>> data)
        {
            if (count != 0)
            {
                int count_left = count / 2;
                int count_right = count - count_left - 1;
                arr[i] = data.Dequeue();
                RearrangeTree(count_left, GetLeftChildIndex(i), data);
                RearrangeTree(count_right, GetRightChildIndex(i), data);

            }
        }

        public void Remove(T node) // исправить!!!
        {
            if (IsEmpty)
                throw new TreeElementRemovalDenial("Cannot remove element from an empty tree");
            if (node == null || !Contains(node))
                throw new TreeElementRemovalDenial("Cannot remove non-existent element");
            /*DeleteFromArray(node);
            SwitchNodes();*/
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
