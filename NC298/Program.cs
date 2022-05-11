using System;
using System.Collections.Generic;

namespace NC298
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal class Solution
    {
        Queue<int> queue1 = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();

        public void push(int element)
        {
            if (queue1.Count != 0)
            {
                queue1.Enqueue(element);
            }
            else
            {
                queue2.Enqueue(element);
            }
        }

        public int pop()
        {
            var result = int.MaxValue;
            if (queue1.Count != 0)
            {
                while (queue1.Count > 1)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
                result = queue1.Dequeue();
            }
            else
            {
                while (queue2.Count > 1)
                {
                    queue1.Enqueue(queue2.Dequeue());
                }
                result = queue2.Dequeue();
            }
            return result;
        }

        public int top()
        {
            var result = int.MaxValue;
            if (queue1.Count != 0)
            {
                while (queue1.Count > 1)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
                result = queue1.Dequeue();
                queue2.Enqueue(result);
            }
            else
            {
                while (queue2.Count > 1)
                {
                    queue1.Enqueue(queue2.Dequeue());
                }
                result = queue2.Dequeue();
                queue1.Enqueue(result);
            }
            return result;
        }

        /// <summary>
        /// 判断栈是否为空
        /// </summary>
        /// <returns></returns>
        public bool empty()
        {
            if (queue1.Count == 0 && queue2.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
