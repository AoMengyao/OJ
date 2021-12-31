using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 1, 4, 1, 6 };
            List<int> result = FindNumsAppearOnce(array);
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 描述
        //        一个整型数组里除了两个数字只出现一次，其他的数字都出现了两次。请写程序找出这两个只出现一次的数字。
        //  提示：输出时按非降序排列。
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static List<int> FindNumsAppearOnce(List<int> array)
        {
            /* *
             * 求解eor 异或操作的和
             * 由于异或操作 N^N=0 0^N=N 的特性
             * 所有最后求出的结果为a^b(即两个求解的数字的异或结果)
             */
            int eor = 0;

            foreach (var item in array)
            {
                eor ^= item;
            }

            /* *
             * 如果a^b!=0，则a和b肯定不相同
             * a和b不相等的话，肯定存在最右侧的1，通过1来进行拆分
             * 所有的结果进行异或操作，则得出a和b
             */
            int a = 0;
            int b = 0;

            int rightOne = (~eor + 1) & eor;

            foreach (var item in array)
            {
                if ((rightOne & item) == 0)
                {
                    a ^= item;
                }
                else
                {
                    b ^= item;
                }
            }

            List<int> result = a > b ? new List<int>() { b, a } : new List<int>() { a, b };

            return result;
        }
    }
}
