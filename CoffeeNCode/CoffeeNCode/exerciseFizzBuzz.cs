using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeNCode
{
    internal class ExerciseFizzBuzz
    {
        public static void Run()
        {
            bool threeDiv = false;
            bool fiveDiv = false;
            
            for (int i = 1; i <= 100; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("{0}: FizzBuzz", i);
                }
                else if (threeDiv)
                {
                    Console.WriteLine("{0}: Fizz", i);
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("{0}: Buzz", i);
                }
                else
                {
                    Console.WriteLine("{0}: {1}", i, i);
                }


            }




            Console.ReadLine();

            /* 
             Rules:
                - If the number is divisible by 3, print "Fizz"   
                - If the number is divisible by 5, print "Buzz"
                - If the number is divisible by both 3 and 5, print "FizzBuzz"
                - If the number is not divisible by either 3 or 5, print the number itself
             */
        }
    }
}
