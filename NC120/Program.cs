using System;
using System.Linq;

namespace NC120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().NumberOf1(-1));
            Console.WriteLine("Hello World!");
        }
    }
    class Solution
    {
        /// <summary>
        /// 第一种办法：n转字符串，然后将字符串中的结果进行求和操作
        ///         var str = Convert.ToString(n, 2);
        ///         return str.ToCharArray().Sum(i => (int) Char.GetNumericValue(i));
        /// 第二种办法：n/2然后计算余数中1的个数（正整数使用，如果是负数的话，会出现一直循环的问题）
        ///            那么特殊处理负数，将符号位改成正的
        ///                    int total = 0;
        ///                    if(n<0){
        ///                      n= n & 0x7FFFFFFF;
        ///                      total++;
        ///                    }
        ///                    while (n != 0)
        ///                    {
        ///                       if(n%2==1)  total++;
        ///                       n=n>>1;
        ///                    }
        ///                    return total;
        /// 第三种办法：n&(n-1)作用：将n的二进制表示中的最低位为1的改为0
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumberOf1(int n)
        {
            // write code here
            int total = 0;
            while (n != 0)
            {
                n = n & (n - 1);
                total++;
            }
            return total;
        }
    }
}
