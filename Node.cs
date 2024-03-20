
namespace BalancedTreeLab
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left; // ссылка на левое поддерево
        public Node<T> Right; // ссылка на правое поддерево
        public int Height;

        public Node(T node = default(T))
        {
            Data = node;
            Left = null;
            Right = null;
            Height = 1;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
