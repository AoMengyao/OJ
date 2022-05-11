using System;
using System.Collections.Generic;
using System.Text;

namespace NC103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = solve("abcd");
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 描述
        //        写出一个程序，接受一个字符串，然后输出该字符串反转后的字符串。（字符串长度不超过1000）
        //  数据范围： 0 \le n \le 10000≤n≤1000
        //  要求：空间复杂度 O(n)O(n)，时间复杂度 O(n)O(n)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string solve(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in str)
            {
                stack.Push(item);
            }
            return new string(stack.ToArray());
        }
    }
}
