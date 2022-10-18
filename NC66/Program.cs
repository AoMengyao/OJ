using System;
using System.Collections.Generic;

namespace NC66
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
        public ListNode FindFirstCommonNode(ListNode pHead1, ListNode pHead2)
        {
            // write code here
            var list = new HashSet<ListNode>();
            while (pHead1 != null)
            {
                list.Add(pHead1);
                pHead1 = pHead1.next;
            }

            while (pHead2 != null)
            {
                if (list.Contains(pHead2))
                {
                    return pHead2;
                }
                else
                {
                    list.Add(pHead2);
                }
                pHead2 = pHead2.next;
            }
            return null;
        }
    }

}
