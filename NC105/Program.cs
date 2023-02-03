// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

namespace NC105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().search(new List<int> { 1, 1, 1, 1, 1 }, 1));
            Console.WriteLine(new Solution().search(new List<int> { 1, 2, 4, 4, 5 }, 3));
            Console.WriteLine(new Solution().search(new List<int> { 1, 2, 4, 4, 5 }, 4));
            Console.WriteLine(new Solution().search(new List<int> { -2, 1, 2 }, 2));
            Console.WriteLine("Hello, World!");
        }
    }

    internal class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 如果目标值存在返回下标，否则返回 -1
         * @param nums int整型一维数组 
         * @param target int整型 
         * @return int整型
         */
        public int search(List<int> nums, int target)
        {
            // write code here
            var l = 0;
            var r = nums.Count - 1;
            var mid = l + (r - l) / 2;
            var oldMid = -1;
            while (l <= r)
            {
                if (nums[mid] == target)
                {
                    oldMid = mid;
                    r = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }

                mid = l + (r - l) / 2;
            }

            return oldMid;
        }
    }
}
