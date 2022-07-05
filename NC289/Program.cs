using System;

namespace NC289
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode phead = new ListNode(2);
            phead.next = new ListNode(5);
            phead.next.next = new ListNode(1);
            phead.next.next.next = new ListNode(9);
            var lists = new Solution().deleteNode(phead, 5);
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
         * @param val int整型 
         * @return ListNode类
         */
        public ListNode deleteNode(ListNode head, int val)
        {
            //空链表
            if (head == null) return null;
            //头节点
            if (head.val == val) return head.next;
            //非空链表
            ListNode pre,del;
            pre = del = head;
            var index = 0;
            //查找要删除的元素
            while (del != null && del.val != val)
            {
                if (index != 0) pre = pre.next;
                del = del.next;
                index++;
            }
            pre.next = del.next;
            return head;
        }
    }
}
