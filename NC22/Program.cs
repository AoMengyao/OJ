using System;
using System.Collections.Generic;
using System.Linq;

namespace NC22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var A = new int[] { 1, 2, 3, 0, 0, 0 };
            var B = new int[] { 2, 5, 6 };
            solution.merge(A, 3, B, 3);
            foreach (var item in A)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            //A = new int[] { 4, 5, 6, 0, 0, 0 };
            //B = new int[] { 1, 2, 3 };
            //solution.merge(A, 3, B, 3);
            A = new int[] { 1, 2, 3, 0, 0, 0 };
            B = new int[] { 4, 5, 6 };
            solution.merge(A, 3, B, 3);
            foreach (var item in A)
            {
                Console.Write(item);
            }
            Console.Read();
        }
    }
    class Solution
    {
        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 
         * @param A int整型一维数组 
         * @param m int整型 
         * @param B int整型一维数组 
         * @param n int整型 
         * @return void
         */
        public void merge(int[] A, int m, int[] B, int n)
        {
            var indexA = m-1;
            var indexB = n-1;
            var index = m + n - 1;
            while (index >= 0)
            {
                if(indexA >= 0 && indexB >= 0)
                {
                    if (A[indexA] < B[indexB])
                    {
                        A[index] = B[indexB];
                        indexB--;
                    }
                    else
                    {
                        A[index] = A[indexA];
                        indexA--;
                    }
                }
                else if (indexA < 0)
                {
                    A[indexB] = B[indexB];
                    indexB--;
                }
                index--;
            }           
        }
    }
}
