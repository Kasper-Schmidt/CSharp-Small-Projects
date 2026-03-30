using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = -1;

            double a = System.Math.Pow(x, 2);
            double b = System.Math.Pow(x, 3);
            double c = System.Math.Sqrt(x);
            double d = System.Math.Abs(x);
            double e = System.Math.Abs(y);


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);


            Console.WriteLine("------------------------------");


            double z = 3.14;

            double f = System.Math.Round(z);
            double g = System.Math.Ceiling(z);
            double h = System.Math.Floor(z);

            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);


            Console.WriteLine("------------------------------");


            double i = 3.99;
            double j = 5;

            double k = System.Math.Max(i, j);
            double l = System.Math.Min(i, j);

            Console.WriteLine(k);
            Console.WriteLine(l);







            Console.ReadKey();

        }
    }
}