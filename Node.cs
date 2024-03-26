
namespace BalancedTreeLab
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left; // ссылка на левое поддерево
        public Node<T> Right; // ссылка на правое поддерево
        public int Height;

        #region Описание NODE
        /*
         * Поле key хранит ключ узла, поле height — высоту поддерева 
         * с корнем в данном узле, поля left и right — 
         * указатели на левое и правое поддеревья. 
         * Простой конструктор создает новый узел (высоты 1) с заданным ключом k.
         * Традиционно, узлы АВЛ-дерева хранят не высоту, 
         * а разницу высот правого и левого поддеревьев 
         * (так называемый balance factor), 
         * которая может принимать только три значения -1, 0 и 1.
         * Здесь же будет храниться именно высота, а разница будет вычисляться
         * в дополнительной функции BalanceFactor
         */
        #endregion

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
