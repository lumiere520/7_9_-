using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_委托的用法
{
    //1.声明委托类型
    delegate void MyDel(int x);

    //2.声明类
    class MyInstObj
    {
        //3.声明方法(实例) 与 委托类型一致
        public void MyM1(int x)
        {
            Console.WriteLine("实例方法: X=" + x);
        }
    }
    class SClass
    {
        //声明方法(实例) 与 委托类型一致
        public static void OtherM2(int x)
        {
            Console.WriteLine("静态的方法: X=" + x);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //4.定义委托
            MyDel delVar;

            //5.关联方法
            MyInstObj myInstObj = new MyInstObj();
            //第一种绑定的样式
            //delVar = new MyDel(myInstObj.MyM1);//关联实例方法
            //dVar = new MyDel(SClass.OtherM2);//关联静态的方法
            //第二种绑定的样式 - 缩写形式
            delVar = myInstObj.MyM1;//关联实例方法
            delVar += SClass.OtherM2;//关联静态的方法

            //+= / -= 添加或删除委托

            //组合委托 +
            MyDel delA = myInstObj.MyM1;
            MyDel delB = SClass.OtherM2;

            MyDel delC = delA + delB;

            //6.调用方法
            //delVar(1);
            delC(1);

            //等待
            Console.ReadKey();

        }
    }
}
