using System;

namespace NC141
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Judge("abcdcba")); 
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static bool Judge(string str)
        {
            // write code here
            int count = str.Length;
            if(count == 1)
            {
                return true;
            }
            else
            {
                int middle = count / 2;
                for (int i = 0; i < middle; i++)
                {
                    if (str[i] != str[count - 1 - i]) return false;
                }
            }
            return true;
        }
    }
}
