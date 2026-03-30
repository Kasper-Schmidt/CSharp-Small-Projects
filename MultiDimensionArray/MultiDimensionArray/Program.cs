using System;

namespace MultiDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] parkingLot = { { "Mustang", "f-150", "Fiesta" }, 
                                     { "Corvette", "Camaro", "Silverado" }, 
                                     { "Corolla", "Camry", "Rav4" } 
                                   };


            parkingLot[0, 1] = "Puma";
            parkingLot[2, 0] = "Tacoma";


            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }


            Console.WriteLine("--------------------------");


            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}