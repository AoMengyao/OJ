using System;
using System.Collections.Generic;

namespace NC288
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param n int整型 最大位数
         * @return int整型一维数组
         */
        public List<int> printNumbers(int n)
        {
            var max = Convert.ToUInt32(Math.Pow(10, n));
            var list = new int[max - 1];
            for (int i = 1; i < max; i++)
            {
                list[i - 1] = i;
            }
            return new List<int>(list);
        }
    }
}
