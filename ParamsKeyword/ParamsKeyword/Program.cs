using System;
using System.ComponentModel.Design;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // params keyword = a method parameter that takes a variable number of arguments
            //                  The parameter type must be a single-dimension array

            double total = CheckOut(3.99, 5.75, 15);

            Console.WriteLine(total);






            Console.ReadKey();
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }

     
    }
}