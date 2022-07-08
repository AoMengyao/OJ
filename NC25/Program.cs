using System;
using System.Collections.Generic;

namespace NC25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode phead = new ListNode(1);
            phead.next = new ListNode(1);
            phead.next.next = new ListNode(2);
            phead.next.next.next = new ListNode(3);
            phead.next.next.next.next = new ListNode(3);
            var list = new Solution().deleteDuplicates(phead);
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
        public ListNode deleteDuplicates(ListNode head)
        {
            //空链表
            if (head == null) return null;
            //获取重复值
            ListNode orign = head;
            //数据
            var data = new List<int>();
            var list = new List<int>();
            var index = default(int);
            while (orign != null)
            {
                if (data.Contains(orign.val))
                {
                    list.Add(index);
                }
                else
                {
                    data.Add(orign.val);
                }
                orign = orign.next;
                index++;
            }
            index = default(int);
            var pre = head;
            var next = head;
            while (next != null)
            {
                if (list.Contains(index))
                {
                    pre.next = next.next;
                    next.next = next.next?.next;
                }
                else
                {
                    if (index != 0) pre = pre.next;
                    next = next.next;
                }
                index++;
            }
            return head;
        }
    }
}
