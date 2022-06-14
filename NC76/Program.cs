using System;
using System.Collections;
using System.Collections.Generic;

namespace NC76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }

        class Solution
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            public void push(int node)
            {
                stack1.Push(node);
            }
            public int pop()
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
                var result = stack2.Pop();
                while (stack2.Count > 0)
                {
                    stack1.Push(stack2.Pop());
                }
                return result;
            }
        }
    }
}
