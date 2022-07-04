using System;

namespace NC365
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().poweroftwo(6));
            Console.WriteLine("Hello World!");
        }
    }
    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param n int整型 
         * @return bool布尔型
         */
        public bool poweroftwo(int n)
        {
            // write code here
            int mi = 1;
            while (mi < n)
            {
                mi <<= 1;
            }
            return mi == n;
        }
    }
}
