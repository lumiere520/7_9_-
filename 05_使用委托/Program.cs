using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_使用委托
{
    delegate double algorithm(double a, double b);
    class Program 
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            Console.WriteLine("Result：{0}", TEST(a, b, Program.Add));
            Console.ReadKey();
        }
        public static double TEST(double a, double b, algorithm function)
        {
            return function(a, b);
        }
        //加法
        public static double Add(double a, double b)
        {
            return a + b;
        }

        //减法
        public static double Sub(double a, double b)
        {
            return a - b;
        }

        //乘法
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        //除法
        public static double Division(double a, double b)
        {
            return a / b;
        }


    }
}
