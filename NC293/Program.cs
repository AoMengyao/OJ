using System;
using System.Collections.Generic;

namespace NC293
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result=new Solution().insert(new List<int>() { 1, 3, 4, 5, 7 },2);
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
         * @param A int整型一维数组 
         * @param val int整型 
         * @return ListNode类
         */
        public ListNode insert(List<int> A, int val)
        {
            // write code here
            A.Add(val);
            A.Sort();
            ListNode node = null;
            ListNode pHead = null;
            for (int i = 0; i < A.Count; i++)
            {
                if (node == null)
                {
                    node = new ListNode(A[i]);
                    pHead = node;
                }
                else
                {
                    node.next = new ListNode(A[i]);
                    node = node.next;
                }                
            }
            return pHead;

        }
    }
}
