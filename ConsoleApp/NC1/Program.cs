using System;

namespace NC1
{
    internal class Program
    {
        /**
         * 描述
         * 
         * 以字符串的形式读入两个数字，编写一个函数计算它们的和，以字符串形式返回。
         * 数据范围：s.length,t.length \le 100000s.length,t.length≤100000，字符串仅由'0'~‘9’构成
         * 要求：时间复杂度 O(n)O(n)
         * 示例1
         * 输入：
         * "1","99"
         * 返回值：
         * "100"
         * 说明：
         * 1+99=100       
         * 示例2
         * 输入：
         * "114514",""
         * 返回值：
         * "114514"
         */
        static void Main(string[] args)
        {
            Console.WriteLine(solve("1", "99"));
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        public static string solve(string s, string t)
        {
            // write code here
            if (s.Length == 0 && t.Length == 0)
            {
                return "0";
            }
            else if (s.Length == 0 && t.Length != 0)
            {
                return t;
            }else if (t.Length == 0 && s.Length != 0)
            {
                return s;
            }
            else
            {
                string big = s.Length > t.Length ? s : t;
                string small = s.Length > t.Length ? t : s;
                int[] result = new int[big.Length + 1];

                small = small.PadLeft(big.Length, '0');

                ushort carry = 0;

                for(int i = big.Length-1; i >=0; i--)
                {
                    ushort.TryParse(big[i].ToString(), out ushort bigTemp);
                    ushort.TryParse(small[i].ToString(), out ushort smallTemp);
                    result[i + 1] = (bigTemp + smallTemp + carry) % 10;
                    carry = (ushort)((bigTemp + smallTemp+carry) / 10);
                }
                result[0] = carry;
                string temp = String.Join("", result);
                return temp[0] == '0' ? temp.Substring(1) : temp;
            }
        }
    }
}
