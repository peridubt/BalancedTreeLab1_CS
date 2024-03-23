using BalacnedTree;

namespace BalancedTreeLab
{
    public class TreeUtils<T> where T : IComparable<T>
    {
        public delegate bool CheckDelegate<T>(Node<T> node);
        public delegate void ActionDelegate<T>(Node<T> node);
        public delegate ITree<T> TreeConstructorDelegate();

        public static bool Exists(ITree<T> tree, CheckDelegate<T> check)
        {
            if (tree.IsEmpty)
                throw new TreeUtilsException("Cannot apply Exists method for an empty tree");
            foreach (var node in tree.Nodes)
            {
                if (check.Invoke(node))
                    return true;
            }
            return false;
        }

        public static ITree<T> FindAll(ITree<T> tree, CheckDelegate<T> check,
            TreeConstructorDelegate createTree)
        {
            if (tree.IsEmpty)
                throw new TreeUtilsException("Cannot apply FindAll method for an empty tree");
            var result = createTree.Invoke();

            foreach (var node in tree.Nodes)
            {
                if (check.Invoke(node))
                {
                    result.Add(node.Data);
                }
            }
            return result;
        }

        public static void ForEach(ITree<T> tree, ActionDelegate<T> action)
        {
            if (tree.IsEmpty)
                throw new TreeUtilsException("Cannot apply ForEach method for an empty tree");
            foreach (var node in tree.Nodes)
            {
                action.Invoke(node);
            }
        }

        public static bool CheckForAll(ITree<T> tree, CheckDelegate<T> check)
        {
            if (tree.IsEmpty)
                throw new TreeUtilsException("Cannot apply CheckForAll method for an empty tree");
            foreach (var node in tree.Nodes)
            {
                if (!check.Invoke(node))
                    return false;
            }
            return true;
        }

        /*public static readonly TreeConstructorDelegate ArrayTreeConstructor = () =>
        {
            ArrayTree<T> treeArr = [];
            return treeArr;
        };

        public static readonly TreeConstructorDelegate LinkedTreeConstructor = () =>
        {
            LinkedTree<T> treeLinked = [];
            return treeLinked;
        };
        */
    }
}
