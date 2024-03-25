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

        /*
         * Обёртка для поля Height в Node
         */
        private int GetHeight(Node<T> node)
        {
            return node != null ? node.Height : 0;
        }

        /*
         * Вычисление разницы между высотами поддеревьев
         */
        private int BalanceFactor(Node<T> node)
        {
            return GetHeight(node.Right) - GetHeight(node.Left);
        }

        /*
         * Восстановление корректного значения поля height 
         * заданного узла (при условии, что значения этого поля 
         * в правом и левом дочерних узлах являются корректными)
         */

        private void FixHeight(Node<T> node)
        {
            int hLeft = GetHeight(node.Left);
            int hRight = GetHeight(node.Right);
            node.Height = (hLeft > hRight ? hLeft : hRight) + 1;
        }

        #region Описание балансировки
        /*
         * В процессе добавления или удаления узлов в АВЛ-дереве 
         * возможно возникновение ситуации, когда balance factor некоторых узлов 
         * оказывается равными 2 или -2, т.е. возникает расбалансировка поддерева. 
         * Для выправления ситуации применяются повороты вокруг тех или иных узлов дерева. 
         * Простой поворот вправо производит следующую трансформацию дерева
         */
        #endregion
        private Node<T> RotateRight(Node<T> node)
        {
            Node<T> t = node.Left;
            node.Left = t.Right;
            t.Right = node;
            FixHeight(node);
            FixHeight(t);
            return t;
        }

        /*
         * Левый поворот является симметричной копией правого
         */
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
            if (!IsEmpty && Contains(data))
                throw new TreeModificationDenial("Element is already in tree");
            root = AddToRoot(root, data);
            Count++;
        }

        #region Описание поиска узла для удаления
        /*
         *  Eсли у найденный узлел не имеет правого поддерева, то по свойству АВЛ-дерева 
         *  слева у этого узла может быть только один единственный дочерний узел (дерево высоты 1),
         *  либо узел p вообще лист. 
         *  В обоих этих случаях надо просто удалить этот узел и вернуть в качестве результата
         *  Node на левый дочерний узел нашего узла.

        Пусть теперь правое поддерево у конкретного узла есть. 
        Находим минимальный ключ в этом поддереве. 
        По свойству двоичного дерева поиска этот ключ находится в конце левой ветки,
        начиная от корня дерева. Применяем рекурсивную функцию
         */
        #endregion
        Node<T> FindMin(Node<T> node)
        {
            return node.Left != null ? FindMin(node.Left) : node;
        }

        /*
         * Еще одна служебная функция будет заниматься удалением 
         * минимального элемента из заданного дерева. 
         * По свойству АВЛ-дерева, у минимального элемента справа 
         * либо подвешен единственный узел, либо там пусто.
         * В обоих случаях надо просто вернуть Node на правый узел 
         * и по пути назад (при возвращении из рекурсии) выполнить балансировку.
         * Сам минимальный узел не удаляется, т.к. он еще пригодится.
         */
        Node<T> RemoveMin(Node<T> node)
        {
            if (node.Left == null)
                return node.Right;
            node.Left = RemoveMin(node.Left);
            return Balance(node);
        }

        Node<T> RemoveFromRoot(Node<T> node, T data)
        {
            /*Сначала находим нужный узел, выполняя те же действия, что и при вставке ключа*/
            if (node == null)
                return null;
            if (data.CompareTo(node.Data) < 0)
                node.Left = RemoveFromRoot(node.Left, data);
            else if (data.CompareTo(node.Data) > 0)
                node.Right = RemoveFromRoot(node.Right, data);
            /*
             * Как только ключ k найден,
             * запоминаем корни p и q левого и правого поддеревьев узла node; 
             * удаляем узел node; 
             * если правое поддерево пустое, то возвращаем левое поддерево; 
             * если правое поддерево не пустое, то находим там минимальный элемент min, 
             * потом его извлекаем оттуда, слева к min подвешиваем p, справа — то, что получилось из q, 
             * возвращаем min после его балансировки.
             */
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
            // Выполнение балансировки после осуществлённого удаления
            return Balance(node);
        }

        public void Remove(T data)
        {
            if (IsEmpty)
                throw new TreeElementRemovalDenial("Cannot remove element from an empty tree");
            if (data == null || !Contains(data))
                throw new TreeElementRemovalDenial("Cannot remove a non-existent element");
            root = RemoveFromRoot(root, data);
            Count--;
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
            Count = 0;
        }
    }
}
