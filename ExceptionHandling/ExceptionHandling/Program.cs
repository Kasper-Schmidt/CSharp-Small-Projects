using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // exceptions = errror that occur during execution
            //         try      = try some cod ethat is considered "dangerous"
            //         catches  = and handles exceptions when they occur
            //         finally  = always excecutes regardless if an exeption is caught or not

            int x;
            int y;
            double result;

            try {
                Console.WriteLine("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("The result is: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something else went wrong.");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting - Finally is usually used to close open files or reset anything.");
            }

            Console.ReadKey();
        }
    }
}