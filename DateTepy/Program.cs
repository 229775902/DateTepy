using System;
using System.Security.Cryptography.X509Certificates;

namespace DateTepy
{
    internal class Program
    {
        private static void Main()
        {
            //变量定义
            //dogName、age、price 都称为变量（Variable）
            //string、int、double 都成为变量的数据类型，或简称类型（Data type）

            //C# 变量必须先定义后使用。定义方式：
            //      数据类型 变量名 = 字面量；
            //整个语句叫赋值语句
            //把右侧的字面值信息给左边的变量储蓄起来。
            string DogName = "Shiny";
            int age = 5;
            double price = 646.980;

            //{0}{1}叫占位符号（Placeholder）。
            //占位符号里面的数字一定必须要从0开始。
            Console.WriteLine("The Dog's name is {0},{1} years old.", DogName, age);
            Console.WriteLine("When I bought her home, the price is {0}.", price);

            Q1 c = new Q1();
            int X = c.Add(5, 10);
            Console.WriteLine(X);
        }
    }

    internal class Q1
    {
        //test 自己的Add。
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}