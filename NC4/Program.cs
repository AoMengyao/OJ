using System;
using System.Collections.Generic;

namespace NC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }


    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         *
         * @param head ListNode类
         * @return bool布尔型
         */
        public bool hasCycle(ListNode head)
        {
            // write code here
            var list = new HashSet<ListNode>();
            while (head != null && head.next != null)
            {
                if (list.Contains(head))
                {
                    return true;
                }
                else
                {
                    list.Add(head);
                }
                head = head.next;
            }
            return false;
        }
    }
}
