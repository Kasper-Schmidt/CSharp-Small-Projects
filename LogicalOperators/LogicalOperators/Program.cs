using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Whats the temeprature outside?");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("The weather is nice outside.");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("Do not go outside, the weather is too extreme");
            }






                Console.ReadKey();
        }
    }
}