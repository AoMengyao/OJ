using System;
using System.Collections.Generic;
using System.Linq;

namespace NC265
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode phead = new ListNode(2);
            phead.next = new ListNode(5);
            phead.next.next = new ListNode(1);
            phead.next.next.next = new ListNode(9);
            var lists = new Solution().printListFromTailToHead(phead);
            Console.WriteLine("Hello World!");
        }
    }

    
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode (int x)
        {
            val = x;
        }
    }
    class Solution
    {
        // 返回从尾到头的列表值序列
        public List<int> printListFromTailToHead(ListNode listNode)
        {
            // write code here
            //第一个方法利用栈
            //Stack<int> list = new Stack<int>();
            //while (listNode != null)
            //{
            //    list.Push(listNode.val);
            //    listNode = listNode.next;
            //}
            //return list.ToArray().ToList();
            //第二个方法使用数组
            var list=new List<int>();
            while (listNode != null)
            {
                list.Add(listNode.val);
                listNode = listNode.next;
            }
            list.Reverse();
            return list;
        }
    }
}
