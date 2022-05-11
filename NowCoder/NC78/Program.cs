using System;

namespace NC78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static ListNode ReverseList(ListNode pHead)
        {
            // write code here
            while (pHead != null && pHead.next != null)
            {
                pHead = pHead.next;
            }
            return pHead;
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
