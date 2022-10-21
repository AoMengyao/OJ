using System;
using System.Collections.Generic;

namespace NC278
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public ListNode deleteDuplication(ListNode pHead)
        {

            // write code here
            if (pHead != null)
            {
                var next = pHead.next;
                var list = new Dictionary<int, int> { { pHead.val, 1 } };

                while (next != null)
                {
                    if (list.ContainsKey(next.val))
                    {
                        list[next.val]++;
                    }
                    else
                    {
                        list.Add(next.val, 1);
                    }
                    next = next.next;
                }
                ListNode link = null;
                ListNode result = null;
                foreach (var item in list.Keys)
                {
                    if (list[item] == 1)
                    {
                        if (link != null)
                        {
                            link.next = new ListNode(item);
                            link = link.next;
                        }
                        else
                        {
                            link = new ListNode(item);
                            result = link;
                        }
                    }
                }
                return result;
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
