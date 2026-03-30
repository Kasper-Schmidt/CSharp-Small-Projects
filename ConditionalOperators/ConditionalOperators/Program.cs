using System;

namespace ConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional operators = used in conditional assignments if a constructor is true/false
            // (condition) ? x : y 


            // Shown first with if else statements
            // Conditional operators after

            double temperature = 25;
            String message;

            if (temperature >= 20)
            {
                message = "It's warm outside.";
            }
            else
            {
                message = "It's cold outside.";
            }

            Console.WriteLine(message);



                Console.WriteLine("-----------------------------");



            message = (temperature >= 20) ? "It's warm outside." : "It's cold outside.";

            Console.WriteLine(message);



            Console.ReadKey();
        }
    }
}