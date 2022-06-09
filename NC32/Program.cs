using System;

namespace NC32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.sqrt(2));
            Console.WriteLine(solution.sqrt(2143195649));
            Console.ReadLine();
        }
    }
    
    internal class Solution
    {
        public int sqrt(int x)
        {
            return (int)Math.Floor(Math.Sqrt(x));
        }
    }
}
