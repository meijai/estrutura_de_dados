﻿using System;
namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            fun1(x);
            Console.ReadKey();
        }

        static void fun1(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                fun1(n - 1);
            }
        }
    }
}