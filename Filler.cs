using BalacnedTree;

namespace BalancedTreeLab
{
    public static class Filler
    {
        public static void FillTree(ITree<int> tree)
        {
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);
            tree.Add(6);
            tree.Add(7);
            tree.Add(8);
            tree.Add(9);
        }

        public static void FillTree(ITree<string> tree)
        {
            tree.Add("apple");
            tree.Add("banana");
            tree.Add("coconut");
            tree.Add("grapes");
            tree.Add("cherry");
            tree.Add("qiwi");
            tree.Add("melon");
            tree.Add("lemon");
            tree.Add("pear");
        }
    }
}
