using System;
using System.Collections.Generic;


namespace NC160
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.AddRange(new int[] { -1, 0, 3, 4, 6, 10, 13, 14 });
            Console.WriteLine(new Solution().search(nums, 13));
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
         * @param target int整型 
         * @return int整型
         */
        public int search(List<int> nums, int target)
        {
            // write code here
            int l = 0;
            int r = nums.Count - 1;
            while (l <= r)
            {
                int mid = (int)Math.Floor((decimal)(l + r) / 2);

                if (target < nums[mid])
                {
                    r = mid - 1;
                }
                else if (target == nums[mid])
                {
                    return mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return -1;
        }
    }
}
