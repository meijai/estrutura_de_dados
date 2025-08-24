using System;
namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started.");
            fun1(4);
            Console.WriteLine("Main method started.");
            Console.ReadKey();
        }
        static void fun1(int n)
        {
            Console.WriteLine("Fun1 started.");
            fun2(3);
            Console.WriteLine("Fun1 ended.");
        }
        static void fun2(int n)
        {
            Console.WriteLine("Fun2 started.");
            fun3(2);
            Console.WriteLine("Fun2 ended.");
        }
        static void fun3(int n)
        {
            Console.WriteLine("Fun3 started.");
            fun4(1);
            Console.WriteLine("Fun3 ended.");
        }
        static void fun4(int n)
        {
            Console.WriteLine("Fun4 started.");
            Console.WriteLine("Fun4 ended.");
        }
    }
}