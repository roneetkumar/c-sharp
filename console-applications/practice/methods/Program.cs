using System;

namespace methods
{

    class Program
    {
        static void Main(string[] args)
        {
            int print(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(print(2, 4));
            Console.WriteLine(print(4, 5));
            Console.WriteLine(print(7, 6));
            Console.WriteLine(print(6, 4));
            Console.WriteLine(print(2, 4));

        }
    }
}
