using System;

namespace ArraysProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            String[] cars = { "BMW", "Mercedes", "Audi", "Ford", "Corvette"};

            Console.WriteLine(cars);
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);


            Console.WriteLine("--------------------------");


            cars[0] = "Lamborghini";
            Console.WriteLine(cars[0]);


            Console.WriteLine("--------------------------");


            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            Console.WriteLine("--------------------------");


            String[] watches = new string[3];

                watches[0] = "Rolex";
                watches[1] = "Omega";
                watches[2] = "Patek Philippe";

            for (int j = 0; j < watches.Length; j++)
            {
                Console.WriteLine(watches[j]);
            }











            Console.ReadKey();
        }
    }
}