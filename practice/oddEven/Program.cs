using System;

namespace oddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 0;
            short b = 0;
            bool check;
            do
            {
                check = false;
                try
                {
                    System.Console.Write("Enter the value for a : ");
                    a = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    System.Console.WriteLine("enter a value greater than zero");
                    check = true;
                }
            } while (check);
            do
            {
                check = false;
                try
                {
                    System.Console.Write("Enter the value for b : ");
                    b = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    System.Console.WriteLine("enter a value greater than zero");
                    check = true;
                }

            } while (check);
            System.Console.WriteLine("the solution for (a*a + b*b + 2*a*b) : {0}", (a * a + b * b + 2 * a * b));
            System.Console.WriteLine("the solution for  (a + b) / (5 + a – b) : {0}", ((a + b) / (5 + a - b)));
            System.Console.WriteLine("the given value for a is {0}", ((a % 2 == 0) ? "even" : "odd"));
            System.Console.WriteLine("the given value for b is {0}", ((b % 2 == 0) ? "even" : "odd"));
            System.Console.WriteLine("the power of a is {0}", (a * a));
            System.Console.WriteLine("the power of b is {0}", (b * b));
            System.Console.ReadKey();
        }
    }
}
