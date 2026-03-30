using System;

namespace IndentationTest
{     class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            if (a + b > 10)
                Console.WriteLine("a + b is bigger than 10");
            else
                Console.WriteLine("a + b is not bigger than 10");



            Console.WriteLine("----------------------------------------");



            int c = 8, d = 10;
            Console.WriteLine(c > d ? "a is greater than b" : "b is greater than a");


        }
    }
}   