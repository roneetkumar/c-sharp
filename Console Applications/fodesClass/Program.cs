using System;

namespace fodesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            clsTime time = new clsTime();

            time.Hour = 85;
            time.Minute = 90;
            time.Second = 70;

            Console.WriteLine(time.ToUniversal());

            DateTime dt = new DateTime();
            System.Console.WriteLine(dt.ToString());

        }
    }
}
