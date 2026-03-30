using System;
using System.ComponentModel.DataAnnotations;

namespace staticMember
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Gallardo");
            Car car3 = new Car("488 Pista");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();



            Console.ReadKey();
        }
    }

    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}