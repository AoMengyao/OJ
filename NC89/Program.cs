using System;
using System.Collections.Generic;
using System.Text;

namespace NC89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result=solution.trans("This is a sample", 16);
            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }
    class Solution
    {
        public string trans(string s, int n)
        {
            // write code here
            var list = s.Split(" ");
            var result = new StringBuilder();
            for (int i = list.Length - 1; i >= 0; i--)
            {
                var chars = list[i].ToCharArray();
                for (int j = chars.Length - 1; j >= 0; j--)
                {
                    var ascii = Convert.ToInt16(chars[j]);
                    chars[j] = (char)(ascii >= 97 ? ascii & 223 : ascii | 32);
                }
                result.Append(chars);
                result.Append(' ');
            }
            return result.ToString().TrimEnd();
        }
    }
}
