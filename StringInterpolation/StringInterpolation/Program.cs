using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // String interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            String firstName = "Kasper";
            String lastName = "Schmidt";
            int age = 27;

            Console.WriteLine($"Hello {firstName} {lastName}, you are {age} years old.");
            Console.WriteLine($"The age, {age, 5} is old");
            Console.WriteLine($"The age {age,-5} is old");






            Console.ReadKey();
        }
    }
}