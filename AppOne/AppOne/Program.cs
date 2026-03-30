using System;

namespace AppOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization
            int y = 321; // declaration + initialization
            int z = x + y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);



            // ------------------------------------------------------------


            int age = 27;

            Console.WriteLine("My age is " + age);


            // ------------------------------------------------------------


            double weight = 90.5;

            Console.WriteLine("Your weight is " + weight + " kg");


            // ------------------------------------------------------------


            bool alive = true;

            Console.WriteLine("Are you alive? " + alive);


            // ------------------------------------------------------------


            char symbol = '@';

            Console.WriteLine("The symbol is " + symbol);


            // ------------------------------------------------------------


            String name = "SxySmth";

            Console.WriteLine("My name is " + name);


            // ------------------------------------------------------------


            String userName = symbol + name;

            Console.WriteLine("Your username is " + userName + symbol);


            // ------------------------------------------------------------


            const double PI = 3.14159;

            Console.WriteLine("PI");


            // ------------------------------------------------------------
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}