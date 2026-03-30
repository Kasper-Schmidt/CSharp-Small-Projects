namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = "";

            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.Write("What will you be doing? (+, -, *, /): ");
                operation = Console.ReadLine();

                if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                {
                    Console.WriteLine("Invalid operation. Try again.");
                }
            }

            double a;
            Console.Write("Enter first number: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid number. Try again.");
                Console.Write("Enter first number: ");
            }

            double b;
            Console.Write("Enter second number: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid number. Try again.");
                Console.Write("Enter second number: ");
            }

            if (operation == "+")
            {
                Console.WriteLine($"{a} {operation} {b} = " + (a + b));
            }
            else if (operation == "-")
            {
                Console.WriteLine($"{a} {operation} {b} = " + (a - b));
            }
            else if (operation == "*")
            {
                Console.WriteLine($"{a} {operation} {b} = " + (a * b));
            }
            else if (operation == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("You cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine($"{a} {operation} {b} = " + (a / b));
                }
            }
        }
    }
}