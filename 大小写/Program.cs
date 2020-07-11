using System;

namespace 大小写
{
  public  delegate string Del(string str);
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "A", "b", "C", "d", "E" };
            test(str, ToUpper);
            for (int i = 0; i < str.Length ; i++)
            {
                Console.Write(str[i]+"\t");
            }
            Console.ReadKey();
        }
        public static void test(string[] str,Del del)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = del(str[i]);
            }
        }
        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }
        public static string ToLower(string str)
        {
           return str.ToLower();
        }
        public static string ToSyh(string  str)
        {
            return "\""+str+"\"";
        }
    }
}
