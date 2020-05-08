using System;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "", collegeName = "", city = "", address = "";
            byte age = 0;
            short id = 0;
            bool check;

            System.Console.Write("Enter your ID : ");
            id = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Enter your name : ");
            name = Console.ReadLine();

            do
            {
                check = false;
                try
                {
                    System.Console.Write("Enter your age : ");
                    age = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Age Cannot Be Negative or Alphabets");
                    check = true;
                }
            } while (age < 1 || check);

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
