using System;
// Roneet Kumar, 2019-05-24, Using try and catch
namespace Excercise2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 0;
            byte num2 = 0;
            double result = 0, power = 0;
            bool test = false;
            short select = 0;

            byte readNum(string text)
            {
                do
                {
                    test = false;
                    try
                    {
                        Console.Write(text);
                        num1 = Convert.ToByte(Console.ReadLine());

                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Only numeric are allowed");
                        test = true;
                    }
                } while (test);
                return num1;
            }

            do
            {

                Console.WriteLine("1. Question 1");
                Console.WriteLine("2. Question 2");
                Console.WriteLine("3. Question 3");
                Console.WriteLine("4. Question 4");
                Console.WriteLine("5. Question 5");
                Console.WriteLine("6. Exit");
                test = false;
                try
                {
                    Console.Write("Select Qusetion : ");
                    select = Convert.ToInt16(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Only values between 1 and 5 are allowed");
                    test = true;
                }
            } while (select < 1 || select > 6 || test);
            Console.Clear();
            switch (select)
            {
                case 1:
                    num1 = readNum("Enter Value 1 (Less than 255) : ");
                    num2 = readNum("Enter Value 2 (Less than 255) : ");
                    result = (num1 * num1) + (num2 * num2) + (2 * num1 * num2);
                    Console.WriteLine("Calculate ({0} * {0} + {1} * {1} + 2 * {0} * {1}) : {2}", num1, num2, (decimal)result);
                    break;
                case 2:

                    num1 = readNum("Enter Value 1 (Less than 255) : ");
                    num2 = readNum("Enter Value 2 (Less than 255) : ");
                    result = (num1 + num2) / (5 + num1 - num2);
                    Console.WriteLine("Calculate ({0} + {1}) / (5 + {0} - {1}) : {2}", num1, num2, (decimal)result);
                    break;
                case 3:
                    num1 = readNum("Enter value to check odd or even : ");
                    string ans = ((num1 % 2) == 0) ? "Even" : "Odd";
                    Console.WriteLine("Number is {0}", ans);
                    break;
                case 4:
                    short i = 0;
                    result = 1;

                    num1 = readNum("Enter the number for power : ");
                    num2 = readNum("Enter the power : ");
                    while (i < num2)
                    {
                        result *= num1;
                        i++;
                    }
                    Console.WriteLine("Result of {0} power {1} is {2}", num1, num2, (decimal)result);
                    break;
                case 5:
                    num1 = readNum("Enter the height of tringle : ");
                    num2 = readNum("Enter the base of tringle : ");
                    result = 0.5 * num1 * num2;
                    Console.WriteLine("Area of Triangle is {0}", (decimal)result);
                    break;
                default: break;
            }
        }
    }
}
