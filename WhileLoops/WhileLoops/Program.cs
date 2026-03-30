using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();


            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }


            Console.WriteLine("Hello " + name);







            Console.ReadKey();
        }
    }
}