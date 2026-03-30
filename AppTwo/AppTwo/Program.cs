using System;

namespace AppTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

         
            Console.WriteLine("-------------------------------");


            int c = 123;
            double d = Convert.ToDouble(c);
            double e = Convert.ToDouble(c) + 0.1;

            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(e.GetType());

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);


            Console.WriteLine("-------------------------------");


            int f = 321;
            String g = Convert.ToString(f);

            Console.WriteLine(f.GetType());
            Console.WriteLine(g.GetType());

            Console.WriteLine(f);
            Console.WriteLine(g);


            Console.WriteLine("-------------------------------");


            String h = "$";
            char i = Convert.ToChar(h);

            Console.WriteLine(h.GetType());
            Console.WriteLine(i.GetType());

            Console.WriteLine(h);
            Console.WriteLine(i);


            Console.WriteLine("-------------------------------");


            String j = "true";
            bool k = Convert.ToBoolean(j);

            Console.WriteLine(j.GetType());
            Console.WriteLine(k.GetType());

            Console.WriteLine(j);
            Console.WriteLine(k);


            Console.ReadKey();
        }
    }
}