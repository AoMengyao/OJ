using System;
using System.Collections.Generic;
using System.Linq;

namespace NC305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.findRepeatNum(new List<int> { 8, 6, 2, 1, 1, 9, 7, 5, 4, 3 }));
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param nums int整型一维数组 
         * @return int整型
         */
        public int findRepeatNum(List<int> nums)
        {
            // write code here
            var all = 0;;
            nums.ForEach(x => all += x);
            var distinct = nums.Distinct().ToList();
            var distinctAll = 0;
            distinct.ForEach(x => distinctAll += x);
            var minus = nums.Count - distinct.Count;
            return (all - distinctAll) / minus;
        }
    }
}
