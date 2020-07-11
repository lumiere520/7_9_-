using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Ginseng_delegate
{
    public class SayHi
    {
        public static void SayHiChiness(string name)
        {
            Console.WriteLine(" 吃了吗?" + name);
        }

        public static void SayHiEnglish(string name)
        {
            Console.WriteLine(" Nice to meet you" + name);
        }

        public static void SayHiJapan(string name)
        {
            Console.WriteLine("歓迎する" + name);
        }

    }
}
