using System;

namespace NC151
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gcd(2297, 8743)); 
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }


        /**
         * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
         *
         * 求出a、b的最大公约数。
         * @param a int 
         * @param b int 
         * @return int
         */
        public static int gcd(int a, int b)
        {
            // write code here
            int remainder, divisor, dividend;
            do
            {  //被除数
                dividend = a < b ? b : a;
                //除数
                divisor = a > b ? b : a;
                //余数
                remainder = dividend % divisor;
                //重置A.B
                a = divisor;
                b = remainder;
            } while (remainder != 0);//如果余数为0，则最后的结果为除数
            return divisor;
        }
    }
}
