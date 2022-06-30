using System;

namespace NC335
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().getNumber("C"));
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param S string字符串 
         * @return int整型
         */
        public int getNumber(string S)
        {
            // write code here
            char[] chars= S.ToCharArray();
            int total = default(int);
            int count = default(int);
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                total += (chars[i] - 'A' + 1) * (int)Math.Pow(26, count++);
            }
            return total;
        }
    };
}
