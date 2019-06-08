using System;

namespace reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (short i = 0; i < 5; i++)
            {
                Console.Write("Enter Number " + (i + 1) + " : ");
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.Write("Array in Reverse is ");

            for (short i = 4; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
