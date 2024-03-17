using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedTreeLab
{
    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }
    }

    public class MyQueue<T>
    {
        QueueItem<T> head;
        QueueItem<T> tail;
        private int count = 0;
        public MyQueue() { }
        public int Count { get => count; set => count = value; }

        public void Enqueue(T value)
        {
            if (head == null)
                tail = head = new QueueItem<T> { Value = value, Next = null };
            else
            {
                var item = new QueueItem<T> { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (head == null) throw new InvalidOperationException();
            var result = head.Value;
            head = head.Next;
            if (head == null)
                tail = null;
            Count--;
            return result;
        }

        public T Peek()
        {
            return head.Value;
        }
    }
}
