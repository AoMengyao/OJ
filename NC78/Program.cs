using System;
using System.Collections;

namespace NC78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode pHead = new ListNode(1);           
            pHead.next = new ListNode(2);
            pHead.next.next = new ListNode(3);
            ReverseList(pHead);
            Console.WriteLine("Hello World!");
        }
        public static ListNode ReverseList(ListNode pHead)
        {
            Stack reverse = new Stack();
            ListNode newHead = null;
            while (pHead!= null)
            {
                reverse.Push(pHead.val);
                pHead = pHead.next;
            }
            while (reverse.Count > 0)
            {
                var item = new ListNode((int)reverse.Pop());
                if (pHead == null)
                {
                    pHead = item;
                    newHead = pHead;
                }
                else
                {
                    pHead.next = item;
                    pHead = pHead.next;
                }
            }
            return newHead;
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
