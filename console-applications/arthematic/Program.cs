using System;

namespace arthematic
{
    class Program
    {
        static void Main(string[] args)
        {
            byte val1, val2;

            System.Console.Write("Enter Your First Number Less Than 255 : ");
            val1 = Convert.ToByte(System.Console.ReadLine());
            System.Console.Write("Enter Your Second Number Less Than 255 : ");
            val2 = Convert.ToByte(System.Console.ReadLine());

            System.Console.WriteLine("\n==========Result of Simple Calculator==========\n");
            System.Console.WriteLine("Addition: {0} + {1} = {2}", val1, val2, (float)val1 + val2);
            System.Console.WriteLine("\n=========================\n");
            System.Console.WriteLine("Substraction: {0} - {1} = {2}", val1, val2, (float)val1 - val2);
            System.Console.WriteLine("\n=========================\n");
            System.Console.WriteLine("Multiplication: {0} * {1} = {2}", val1, val2, (float)val1 * val2);
            System.Console.WriteLine("\n===============================\n");
            System.Console.WriteLine("Division: {0} / {1} = {2}", val1, val2, (float)val1 / val2);
            System.Console.WriteLine("\n=========================\n");
            System.Console.WriteLine("Press any Key to Quit");
            System.Console.ReadKey();

        }
    }
}
