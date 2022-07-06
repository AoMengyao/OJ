using System;
using System.Collections.Generic;

namespace NC322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode phead = new ListNode(1);
            phead.next = new ListNode(2);
            phead.next.next = new ListNode(3);
            phead.next.next.next = new ListNode(4);
            Console.WriteLine(new Solution().middleNode(phead).val);
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
         * @return ListNode类
         */
        public ListNode middleNode(ListNode head)
        {
            // write code here
            List<int> list = new List<int>();
            ListNode orign = head;
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            int index = (int)Math.Ceiling((decimal)(list.Count / 2));
            int current = 0;
            while (current<index)
            {
                current++;
                orign = orign.next;
            }
            return orign;
        }
    }
}
