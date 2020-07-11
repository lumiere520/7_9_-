using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串分割
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2018-08-08";
            //char[] cha = { '-' };
            //string[] str1 = str.Split(cha, StringSplitOptions.RemoveEmptyEntries);
            string[] str1 = str.Split(new char[]{'-' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日", str1[0], str1[1], str1[2]);
            string str2 = "大纪元";
            if (str2.Contains("大纪元")) ;
            {
              str2   =str2.Replace("纪元","妓院");
            }
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
