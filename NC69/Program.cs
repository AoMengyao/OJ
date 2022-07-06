using System;

namespace NC69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode phead = new ListNode(1);
            phead.next = new ListNode(2);
            phead.next.next = new ListNode(3);
            phead.next.next.next = new ListNode(4);
            phead.next.next.next.next = new ListNode(5);
            Console.WriteLine(new Solution().FindKthToTail(phead,2).val);
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
         * @param pHead ListNode类 
         * @param k int整型 
         * @return ListNode类
         */
        public ListNode FindKthToTail(ListNode pHead, int k)
        {
            // write code here
            int total = 0;
            ListNode pHeadCopy = pHead;
            while (pHead != null)
            {
                pHead = pHead.next;
                total++;
            }
            int current = 0;
            if (total < k) return null;
            while (current < total - k)
            {
                pHeadCopy = pHeadCopy.next;
                current++;
            }
            return pHeadCopy;
        }
    }
}
