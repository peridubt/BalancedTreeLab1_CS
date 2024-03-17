using BalancedTreeLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Классы, не требующие рассмотрения/изменения:
1) TreeUtils;
2) MyQueue;
3) Node;
4) TreeUtils;
5) TreeException;
6) UnmutableTree.

Классы, в которых надо разобраться:
1. ITree - какой шаблонный тип должно иметь свойство Nodes: <Node<T>> или <T>?

2. ArrayTree - точно ли сбалансированное дерево будет работать 
на основе простого добавления элементов в массив? Если да, то как реализовать?

3. LinkedTree - какая взаимосвязь у данного класса со свойством Nodes? 
Точно ли правильное добавление и удаление происходит?
Нужна ли каждый раз перебалансировка дерева?

4. LinkedList - нужно ли делать список связанным, а не на основе массива? 
Добавить метод удаления.


Общая проблема: каким образом должно выводиться дерево в интерфейс программы?
Решение 1: через TreeView в отдельном окне. 
Вытекающая проблема -> как связать классы Linked и Array с элементами TreeView?

Решение 2: простая печать дерева с помощью текста в TextBox (так же в отдельном окне).
 */


namespace BalacnedTree
{
    public interface ITree<T> : IEnumerable<T> where T : IComparable<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        IEnumerable<Node<T>> Nodes { get; set; }

        void Add(T node);
        void Clear();
        bool Contains(T node);
        void Remove(T node);
    }
}
