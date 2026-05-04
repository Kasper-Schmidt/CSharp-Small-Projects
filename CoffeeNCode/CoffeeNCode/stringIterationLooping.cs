using System;
using System.Threading;

namespace CoffeeNCode
{
    internal class StringIterationLooping
    {
        public static void Run()
        {
            string message = "Supercars are awesome!";

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(50);
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains("c"));
            Console.WriteLine(message.Contains("D"));




            Console.WriteLine();
            Console.WriteLine("------- ELLER -------");
            Console.WriteLine();




            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('a'))
                {
                    contains = true;
                    break;
                }
            }

            Console.WriteLine(contains);







            Console.ReadKey();
        }
    }
}
