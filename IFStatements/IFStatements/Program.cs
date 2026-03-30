using System;

namespace IFStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age <= 0)
            { 
                Console.WriteLine("You havent been born yet");
            }
            else if (age > 100)
            {
                Console.WriteLine("You are a very old person");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }


            Console.WriteLine("------------------------------");


            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("Please enter a name");
            }
            else
            { 
                Console.WriteLine("Hello " + name);
            }


            Console.WriteLine("------------------------------");


            Console.WriteLine("Please enter your name");
            String myName = Console.ReadLine();

            if (myName != "")
            {

                Console.WriteLine("Hello " + myName);
            }
            else
            {
                Console.WriteLine("Please enter a name");
            }


            Console.ReadKey();
        }
    }
}