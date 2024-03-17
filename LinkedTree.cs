using BalacnedTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        private Node<T> BalanceOut(int count, IEnumerator<Node<T>> node)
        {
            Node<T> result = null;
            if (count != 0)
            {
                int count_left = count / 2;
                int count_right = count - count_left - 1;
                result = new Node<T> { Data = node.Current.Data };
                node.MoveNext();
                result.left = BalanceOut(count_left, node);
                result.right = BalanceOut(count_right, node);
            }
            return result;
        }
        // добавление и удаление посмотреть в интернете
        public void Add(T node)  // посмотреть, нужно ли делать перебалансировку дерева
        {
            /*if (root == null)
            {
                root = new Node<T>(node);
                list.Add(root);
                Count++;
                return;
            }
            MyQueue<Node<T>> q = new MyQueue<Node<T>>();
            Node<T> temp = root;
            q.Enqueue(temp);

            while (q.Count != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (temp.left == null)
                {
                    temp.left = new Node<T>(node);
                    list.Add(temp.left);
                    break;
                }
                else
                    q.Enqueue(temp.left);

                if (temp.right == null)
                {
                    temp.right = new Node<T>(node);
                    list.Add(temp.right);
                    break;
                }
                else
                    q.Enqueue(temp.right);
            }*/
            list.AddLast(new Node<T> { Data = node });
            Count++;
            IEnumerator<Node<T>> enumerator = list.GetEnumerator();
            enumerator.MoveNext();
            root = BalanceOut(Count, enumerator);
            list.RemoveFirst(); list.AddFirst(root);
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
            if (!Contains(node))
                throw new TreeElementRemovalDenial("Cannot remove a non-existent element");

            list.Remove(FindFirstEntry(node));
            IEnumerator<Node<T>> enumerator = list.GetEnumerator();
            enumerator.MoveNext();
            root = BalanceOut(Count, enumerator);
            list.RemoveFirst(); list.AddFirst(root);
            Count--;
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
