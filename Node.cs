using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedTreeLab
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> left; // ссылка на левое поддерево
        public Node<T> right; // ссылка на правое поддерево

        public Node(T node = default(T)) 
        {
            Data = node;
            this.left = null;
            this.right = null;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
