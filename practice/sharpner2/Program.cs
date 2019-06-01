using System;

namespace sharpner2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string collegeName;
            string city;
            string address;
            byte age;
            short id;

            System.Console.Write("Enter your ID : ");
            id = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Enter your name : ");
            name = Console.ReadLine();
            System.Console.Write("Enter your age : ");
            age = Convert.ToByte(Console.ReadLine());
            System.Console.Write("Enter your College Name : ");
            collegeName = Console.ReadLine();
            System.Console.Write("Enter your City : ");
            city = Console.ReadLine();
            System.Console.Write("Enter your Address : ");
            address = Console.ReadLine();

            System.Console.WriteLine("Student Info : ");
            System.Console.WriteLine("My Name is {0}, I am {1} Years Old. My Student id is {2}", name, age, id);
            System.Console.WriteLine("{0}, {1}, {2}", collegeName, address, city);
            System.Console.ReadKey();

        }
    }
}
