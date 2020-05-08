using System;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            clsTime time = new clsTime(15, 32, 44);

            Console.WriteLine(time.ToUniversal());
            Console.WriteLine(time.ToStandard());

        }
    }
}
