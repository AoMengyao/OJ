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
            Console.ReadLine();
        }
        public static string solve(string s, string t)
        {           
            if (s.Length == 0 && t.Length == 0)
            { 
                // 判断是否为空，返回0
                return "0";
            }
            else if (s.Length == 0 && t.Length != 0)
            {
                // 判断s是否为空，返回t
                return t;
            }
            else if (t.Length == 0 && s.Length != 0)
            {
                // 判断t是否为空，返回s
                return s;
            }
            else
            {
                // 两者都是非空情况下判断字符串长短
                string big = s.Length > t.Length ? s : t;
                string small = s.Length > t.Length ? t : s;
                // 存储结果为最大值位数+1位的ushort数组
                // 因为是正整数，所有不存在负数
                ushort[] result = new ushort[big.Length + 1];
                //用0不全，编程和big一样的位数
                small = small.PadLeft(big.Length, '0');
                //进位位
                ushort carry = 0;
                //从个位开始计算，10进制计算
                for(int i = big.Length-1; i >=0; i--)
                {
                    var bigTemp = ushort.MinValue;
                    var smallTemp = ushort.MinValue;
                    ushort.TryParse(big[i].ToString(), out bigTemp);
                    ushort.TryParse(small[i].ToString(), out smallTemp);
                    result[i + 1] = (ushort)((bigTemp + smallTemp + carry) % 10);
                    carry = (ushort)((bigTemp + smallTemp + carry) / 10);
                }
                //最后一位为最后进位位
                result[0] = carry;
                //将result转为字符串
                string temp = String.Join("", result);
                //根据首位是否为0，进行结果取值
                return temp[0] == '0' ? temp[1..] : temp;
            }
        }
    }
}
