using System;
using System.Collections.Generic;

namespace NC74
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.AddRange(new int[] { 1, 2, 3, 3, 3, 3, 4, 5 });
            Console.WriteLine(new Solution().GetNumberOfK(nums, 3));
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param data int整型一维数组 
         * @param k int整型 
         * @return int整型
         */
        public int GetNumberOfK(List<int> data, int k)
        {
            // write code here
            return search(data, k + 0.5) - search(data, k - 0.5);
        }

        //public int GetNumberOfK(List<int> data, int k)
        //{
        //    // write code here
        //    int l = 0;
        //    int r = data.Count - 1;
        //    int count = 0;
        //    int index = -1;
        //    while (l <= r)
        //    {
        //        int mid = (int)Math.Floor((decimal)(l + r) / 2);
        //        if (k < data[mid])
        //        {
        //            r = mid - 1;
        //        }
        //        else if (k == data[mid])
        //        {
        //            index = mid;
        //            break;
        //        }
        //        else
        //        {
        //            l = mid + 1;
        //        }
        //    }
        //    if (index == -1)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        var orign = index + 1;
        //        while (index >= 0 && data[index] == k)
        //        {
        //            count++;
        //            index--;
        //        }
        //        while (orign < data.Count && data[orign] == k)
        //        {
        //            count++;
        //            orign++;
        //        }
        //        return count;
        //    }
        //}

        public int search(List<int> nums, double target)
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
            return l;
        }
    }
}
