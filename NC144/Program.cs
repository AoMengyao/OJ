using System;
using System.Linq;

namespace NC144
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().countBitDiff(0, 2147483647));
            Console.WriteLine("Hello World!");
        }
    }
    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param m int整型 
         * @param n int整型 
         * @return int整型
         */
        public int countBitDiff(int m, int n)
        {
            // write code here
            int temp = m ^ n;
            int count = 0;
            while (temp != 0)
            {
                if (temp % 2 == 1) count++;
                temp = temp >> 1;
            }
            return count;
        }
    }


}
