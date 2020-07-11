using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _02_No_delegate;
using _03_Ginseng_delegate;

namespace _01_委托节约代码
{
    //委托->有参/无参
    public delegate void DEL();
    public delegate void DelSayHi(string name);


    class Program
    {
        static void Main(string[] args)
        {
            //无委托-用那个函数就调用那个函数
            //Say.SayChinese();
            //Say.SayEnglish();
            //Say.SayJapan();
            //Console.ReadKey();

            //使用委托 有参的形式
            DelSayHi del = new DelSayHi(SayHi.SayHiEnglish);
            DelSayHi da = SayHi.SayHiEnglish;//缩写
            del("教练");

            TEST("嘉佳", SayHi.SayHiChiness);
            TEST("罗老师", SayHi.SayHiJapan);

            Console.ReadKey();
        }
        //自定义的方法
        public static void TEST(string name, DelSayHi DEL)
        {
            DEL(name);
        }

    }
}
