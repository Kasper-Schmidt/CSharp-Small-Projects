using System;

namespace AritmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            int friends = 5;
            int moreFriends = 5;
            int otherFriends = 5;

            friends = friends + 1;
            moreFriends += 1;
            otherFriends++;

            Console.WriteLine(friends);
            Console.WriteLine(moreFriends);
            Console.WriteLine(otherFriends);


            Console.WriteLine("-----------------------");


            int enemys = 5;
            int moreEnemies = 5;
            int otherEnemies = 5;

            enemys = enemys - 1;
            moreEnemies -= 1;    
            otherEnemies--;

            Console.WriteLine(enemys);
            Console.WriteLine(moreEnemies);
            Console.WriteLine(otherEnemies);


            Console.WriteLine("-----------------------");


            int girls = 5;
            int moreGirls = 5;

            girls = girls * 2;
            moreGirls *= 2;

            Console.WriteLine(girls);
            Console.WriteLine(moreGirls);



            Console.WriteLine("-----------------------");


            int cars = 5;
            int moreCars = 5;

            cars = cars / 2;
            moreCars /= 2;

            Console.WriteLine(cars);
            Console.WriteLine(moreCars);


            Console.WriteLine("-----------------------");


            int watches = 10;

            int remainder = watches % 3;

            Console.WriteLine(remainder);






            Console.ReadKey();
        }
    }
}
