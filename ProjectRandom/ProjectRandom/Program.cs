using System;

namespace ProjectRandom
{
    class Program
    {
        static void Main(string[] args)
        {



            Random random = new Random();

            int num1 = random.Next(1, 7); // sidste tal er excluded, så dette er mellem 1 og 6

            Console.WriteLine(num1);


        
            Console.WriteLine("--------------------------------");



            double num2 = random.NextDouble();

            Console.WriteLine(num2);


            Console.WriteLine("--------------------------------");


            int num3 = random.Next(1, 7);
            int num4 = random.Next(1, 7);
            int num5 = random.Next(1, 7);

            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);






            Console.ReadKey();
        }
    }
}