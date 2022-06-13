using System;
using System.Collections.Generic;

namespace NC200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.moveZeroes(new List<int>() { 0, 0 });
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param nums int整型一维数组 
         * @return int整型一维数组
         */
        public List<int> moveZeroes(List<int> nums)
        {
            var result = new List<int>();
            if (nums.Count > 0) 
            {
                result=nums.FindAll(x => x != 0);        
                result.AddRange(new int[nums.Count - result.Count]);
            }
            return result;
        }
    }
}
