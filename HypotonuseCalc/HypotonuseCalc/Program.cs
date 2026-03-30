using System;

namespace HypotonuseCalc

    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());


            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine($"The hypotenuse is: {c}");





            Console.ReadKey();
        }
    }
}