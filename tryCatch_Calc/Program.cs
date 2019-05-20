using System;

namespace arthematic
{
    class Program
    {
        static void Main(string[] args)
        {
            long val1, val2;
            val1 = val2 = 0;
            bool check;
            do
            {
                check = false;
                try
                {
                    Console.Write("Enter Your First Number to Calculate : ");
                    val1 = Convert.ToInt64(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError : Please Enter Numeric Value\n");
                    check = true;
                }
            } while (check);

            do
            {
                check = false;
                try
                {
                    Console.Write("Enter Your Second Number to Calculate: ");
                    val2 = Convert.ToInt64(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError : Please Enter Numeric Value\n");
                    check = true;
                }
            } while (check);

            Console.WriteLine("\n\t==========Result of Simple Calculator==========\n");
            Console.WriteLine("Addition: {0} + {1} = {2}", val1, val2, (decimal)val1 + val2);
            Console.WriteLine("\n=========================\n");
            Console.WriteLine("Substraction: {0} - {1} = {2}", val1, val2, (decimal)val1 - val2);
            Console.WriteLine("\n=========================\n");
            Console.WriteLine("Multiplication: {0} * {1} = {2}", val1, val2, (decimal)val1 * val2);
            Console.WriteLine("\n===============================\n");
            Console.WriteLine("Division: {0} / {1} = {2}", val1, val2, (decimal)val1 / val2);
            Console.WriteLine("\n=========================\n");
            Console.WriteLine("Press any Key to Quit");
            Console.ReadKey();
        }
    }
}
