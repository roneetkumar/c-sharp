using System;

namespace Exercise2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] num1 = new byte[5];
            byte[] num2 = new byte[5];
            double[] result = new double[5];
            string[] oddEven = new string[5];
            bool test = false;
            byte temp = 0;
            short select = 0;

            byte readNum(string text)
            {
                do
                {
                    test = false;
                    try
                    {
                        Console.Write(text);
                        temp = Convert.ToByte(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Only numeric are allowed");
                        test = true;
                    }
                } while (test);
                return temp;
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
                    for (short i = 0; i < 5; i++)
                    {
                        Console.WriteLine("{0}.", i + 1);
                        num1[i] = readNum("Enter Value 1 (Less than 255) : ");
                        num2[i] = readNum("Enter Value 2 (Less than 255) : ");
                        result[i] = (num1[i] * num1[i]) + (num2[i] * num2[i]) + (2 * num1[i] * num2[i]);
                        Console.WriteLine("\nCalculation ({0} * {0} + {1} * {1} + 2 * {0} * {1}) : {2}", num1[i], num2[i], (decimal)result[i]);
                    }
                    break;
                case 2:
                    for (short i = 0; i < 5; i++)
                    {
                        Console.WriteLine("{0}.", i + 1);
                        num1[i] = readNum("Enter Value 1 (Less than 255) : ");
                        num2[i] = readNum("Enter Value 2 (Less than 255) : ");
                        result[i] = (num1[i] + num2[i]) / (5 + num1[i] - num2[i]);
                        Console.WriteLine("\nCalculation ({0} + {1}) / (5 + {0} - {1}) : {2}", num1[i], num2[i], (decimal)result[i]);
                    }
                    break;
                case 3:
                    for (short i = 0; i < 5; i++)
                    {
                        Console.WriteLine("{0}.", i + 1);
                        num1[i] = readNum("Enter value to check odd or even : ");
                        oddEven[i] = ((num1[i] % 2) == 0) ? "Even" : "Odd";
                        Console.WriteLine("\nNumber is {0}", oddEven[i]);
                    }
                    break;
                case 4:
                    for (short i = 0; i < 5; i++)
                    {
                        short j = 0;
                        result[i] = 1;

                        Console.WriteLine("{0}.", i + 1);
                        num1[i] = readNum("Enter the number for power : ");
                        num2[i] = readNum("\nEnter the power : ");
                        while (j < num2[i])
                        {
                            result[i] *= num1[i];
                            j++;
                        }
                        Console.WriteLine("Result of {0} power {1} is {2}", num1[i], num2[i], (decimal)result[i]);
                    }
                    break;
                case 5:
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("{0}.", i + 1);
                        num1[i] = readNum("Enter the height of tringle : ");
                        num2[i] = readNum("Enter the base of tringle : ");
                        result[i] = 0.5 * num1[i] * num2[i];
                        Console.WriteLine("Area of Triangle is {0}", (decimal)result[i]);
                    }
                    break;
                default: break;
            }

        }
    }
}
