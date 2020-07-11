using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_不使用委托
{
    public enum Operator
    {
        加,减,乘,除
    }

    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            Console.WriteLine("Result：{0}", Calculate(a,b,Operator.加));
        }

        public static double Calculate(double a, double b, Operator o)
        {
            switch (o)
            {
                case Operator.加:
                    return Add(a, b);
                case Operator.减:
                    return Sub(a, b);
                case Operator.乘:
                    return Multiplication(a,b);
                case Operator.除:
                    return Division(a,b);
                default:
                    return 0;
            }
        }

        //加法
        public static double Add(double a,double b)
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
