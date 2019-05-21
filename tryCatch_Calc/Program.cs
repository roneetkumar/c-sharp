using System;

namespace arthematic
{
    class Program
    {
        static void Main(string[] args)
        {
            long val1 = 0, val2 = 0;
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
                    Console.WriteLine("\nError : Please Enter Numeric Decimal Value\n");
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
                    Console.WriteLine("\nError : Please Enter Numeric Decimal Value\n");
                    check = true;
                }
            } while (check);


            Console.WriteLine("\n==========Result of Simple Calculator==========\n");
            Console.WriteLine("Addition: \n{0} + {1} = {2,20}", val1, val2, (decimal)val1 + val2);
            Console.WriteLine("\n=========================\n");
            Console.WriteLine("Substraction: \n{0} - {1} = {2,20}", val1, val2, (decimal)val1 - val2);
            Console.WriteLine("\n=========================\n");
            Console.WriteLine("Multiplication: \n{0} * {1} = {2,20}", val1, val2, (decimal)val1 * val2);
            Console.WriteLine("\n===============================\n");
            Console.WriteLine("Division: \n{0} / {1} = {2,20}", val1, val2, (decimal)val1 / val2);
            Console.WriteLine("\n=========================\n");
            Console.WriteLine("Press any Key to Quit");
            Console.ReadKey();
        }
    }
}
