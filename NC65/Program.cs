using System;

namespace NC65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(4));
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 斐波那契数列
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci(int n)
        {
            return (n == 1 || n == 2) ? 1 : Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
