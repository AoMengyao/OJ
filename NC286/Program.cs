using System;
using System.Collections.Generic;

namespace NC286
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param array int整型一维数组 
         * @return int整型一维数组
         */
        public List<int> reOrderArrayTwo(List<int> array)
        {
            // write code here
            var even = array.FindAll(x => x % 2 == 0);
            var odd = array.FindAll(x => x % 2 == 1);
            odd.AddRange(even);
            return odd;
        }
    }
}
