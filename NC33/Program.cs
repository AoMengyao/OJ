using System;

namespace NC33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode pHead1 = null;

            var pHead2 = new ListNode(1);

            var pHead3 = new Solution().Merge(pHead1, pHead2);
            Console.WriteLine("Hello World!");
        }
    }
    class Solution
    {
        public ListNode Merge(ListNode pHead1, ListNode pHead2)
        {
            //空链表
            if (pHead1 == null && pHead2 == null) return null;
            //非空链表
            ListNode head = null;
            ListNode result = null;
            while (pHead1!=null && pHead2!=null)
            {
                if(head == null)
                {
                    if (pHead1.val < pHead2.val)
                    {
                        head = new ListNode(pHead1.val);
                        pHead1 = pHead1.next;
                    }
                    else
                    {
                        head = new ListNode(pHead2.val);
                        pHead2 = pHead2.next;
                    }
                    result = head;
                }
                else
                {
                    if (pHead1.val < pHead2.val)
                    {
                        head.next = new ListNode(pHead1.val);
                        pHead1 = pHead1.next;
                        head = head.next;
                    }
                    else
                    {
                        head.next = new ListNode(pHead2.val);
                        pHead2 = pHead2.next;
                        head = head.next;
                    }
                }
            }
            if (pHead1 == null)
            {
                if (head == null)
                {
                    head = new ListNode(pHead2.val);
                    head.next = pHead2.next;
                    result = head;
                }
                else
                {
                    head.next = pHead2;
                }
            }
            if (pHead2== null)
            {
                if (head == null)
                {
                    head = new ListNode(pHead1.val);
                    head.next = pHead1.next;
                    result = head;
                }
                else
                {
                    head.next = pHead1;
                }
            }
            return result;
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
}
