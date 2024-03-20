using BalacnedTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BalancedTreeLab
{
    public class TreeUtils<T> where T : IComparable<T>
    {
        public delegate bool CheckDelegate<T>(Node<T> node);
        public delegate void ActionDelegate<T>(Node<T> node);
        public delegate ITree<T> TreeConstructorDelegate();

        public static ITree<T> ArrayTreeConstructor(TreeConstructorDelegate createArray)
        {
            if (createArray == null)
                throw new TreeCreationException("Delegate should be defined");
            return createArray.Invoke();
        }

        public static ITree<T> LinkedTreeConstructor(TreeConstructorDelegate createLinked)
        {
            if (createLinked == null)
                throw new TreeCreationException("Delegate should be defined");
            return createLinked.Invoke();
        }

        public static bool Exists(ITree<T> tree, CheckDelegate<T> check)
        {
            if (tree.IsEmpty)
                throw new TreeUtilsException("Cannot apply Exists method for an empty tree");
            foreach (var node in tree.Nodes)
            {
                if (node != null)
                {
                    if (check.Invoke(node))
                        return true;
                }
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
                if (node != null)
                {
                    if (check.Invoke(node))
                    {
                        result.Add(node.Data);
                    }
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
                if (node != null)
                    action.Invoke(node);
            }
        }

        public static bool CheckForAll(ITree<T> tree, CheckDelegate<T> check)
        {
            if (tree.IsEmpty)
                throw new TreeUtilsException("Cannot apply CheckForAll method for an empty tree");
            foreach (var node in tree.Nodes)
            {
                if (node != null)
                {
                    if (!check.Invoke(node))
                        return false;
                }
            }
            return true;
        }
    }
}
