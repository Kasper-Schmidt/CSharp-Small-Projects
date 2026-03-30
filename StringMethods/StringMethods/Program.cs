using System;

namespace StringMethods
{

    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Kasper Schmidt";


            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            fullName = fullName.ToLower();
            Console.WriteLine(fullName);


            Console.WriteLine("------------------------------");


            String phoneNumber = "123-456-789";
            String numberPhone = "123-456-789";

            phoneNumber = phoneNumber.Replace("-", " ");
            Console.WriteLine(phoneNumber);

            numberPhone = numberPhone.Replace("-", "+");
            Console.WriteLine(numberPhone);


            Console.WriteLine("------------------------------");


            String username = fullName.Insert(0, "@");
            Console.WriteLine(username);

            String userName = fullName.Insert(0, "Mr. ");
            Console.WriteLine(userName);

            Console.WriteLine("Length of name: " + fullName.Length);


            Console.WriteLine("------------------------------");


            String firstName = fullName.Substring(0, 6);
            String lastName = fullName.Substring(7, 7);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);





            Console.ReadKey();
        }
    }
}