using System;

namespace CoffeeNCode
{
    internal class TryParse
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            int num = 0;

            Console.WriteLine(num);

            bool success = int.TryParse(numInput, out num);





            Console.WriteLine("------- WHILE LOOP -------");





            bool success2 = true;

            while (success2)
            {
                Console.Write("Enter a number: ");
                string numInput2 = Console.ReadLine();

                if (int.TryParse(numInput, out int num2))
                {
                    success2 = false;
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }
            }

        



            Console.ReadLine();

        }
    }
}