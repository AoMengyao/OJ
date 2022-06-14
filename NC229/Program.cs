using System;
using System.Collections.Generic;

namespace NC229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().isUnique("nowcoder"));
            Console.WriteLine("Hello World!");
        }
    }
    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param str string字符串 
         * @return bool布尔型
         */
        public bool isUnique(string str)
        {
            // write code here
            HashSet<char> set = new HashSet<char>(str.ToCharArray());
            return str.Length == set.Count;
        }
    }
}
