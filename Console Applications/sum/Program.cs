using System;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter Number 1 : ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Total of " + num1 + " and " + num2 + " is " + (num1 + num2));
        }
    }
}
