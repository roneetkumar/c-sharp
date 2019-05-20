using System;

namespace calc_project1
{
    class Program
    {
        static void Main(string[] args)
        {
            char restartOperation;
            do
            {
                float result, value1, value2;
                ushort select, noOfValues, i;
                bool check;

                result = value1 = value2 = 0;
                select = 0;
                restartOperation = '0';

                Console.WriteLine("\t\tCalculator");
                Console.WriteLine("\t\t``````````");
                Console.WriteLine("\t\tBy: Roneet");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");
                Console.WriteLine("5. Quit");
                do
                {
                    check = false;
                    try
                    {
                        Console.Write("Enter your choice (1-5) : ");
                        select = Convert.ToUInt16(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You Cannot Enter No's other than 1-5 :");
                        check = true;
                    }
                } while (select < 1 || select > 5 || check);
                do
                {
                    Console.WriteLine("\t\t Calculator");
                    Console.WriteLine("\t\t ``````````");
                    Console.Clear();
                    switch (select)
                    {
                        case 1:
                            result = 0;
                            Console.WriteLine("\t\t Addition\n");
                            Console.Write("Enter the number of values to add : ");
                            noOfValues = Convert.ToUInt16(Console.ReadLine());
                            for (i = 0; i < noOfValues; i++)
                            {
                                Console.Write("Value {0} : ", (i + 1));
                                value1 = float.Parse(Console.ReadLine());
                                result += value1;
                            }
                            Console.WriteLine("The result is {0}\n", result);
                            do
                            {
                                Console.Write("Restart ? ( Y or N )");
                                restartOperation = Convert.ToChar(Console.ReadLine().ToUpper());
                            } while (!(restartOperation == 'Y' || restartOperation == 'N'));
                            break;
                        case 2:
                            result = 0;
                            Console.WriteLine("\t\t Subtraction\n");
                            Console.Write("Value 1 : ");
                            value1 = float.Parse(Console.ReadLine());
                            Console.Write("Value 1 : ");
                            value2 = float.Parse(Console.ReadLine());
                            result = value1 - value2;
                            Console.WriteLine("The result is {0}\n", result);
                            do
                            {
                                Console.Write("Restart ? ( Y or N )");
                                restartOperation = Convert.ToChar(Console.ReadLine().ToUpper());
                            } while (!(restartOperation == 'Y' || restartOperation == 'N'));
                            break;
                        case 3:
                            result = 0;
                            Console.WriteLine("\t\t Division\n");
                            Console.WriteLine("Enter the value to divide : ");
                            value1 = float.Parse(Console.ReadLine());
                            Console.Write("Enter The divider : ");
                            value2 = float.Parse(Console.ReadLine());
                            result = value1 / value2;
                            Console.WriteLine("The result is {0}\n", result);
                            do
                            {
                                Console.Write("Restart ? ( Y or N )");
                                restartOperation = Convert.ToChar(Console.ReadLine().ToUpper());
                            } while (!(restartOperation == 'Y' || restartOperation == 'N'));
                            break;
                        case 4:
                            result = 1;
                            Console.WriteLine("\t\t Multiplication\n");
                            Console.Write("Enter the number of values to multiply : ");
                            noOfValues = Convert.ToUInt16(Console.ReadLine());
                            for (i = 0; i < noOfValues; i++)
                            {
                                Console.Write("Value {0} : ", (i + 1));
                                value1 = float.Parse(Console.ReadLine());
                                result *= value1;
                            }
                            Console.WriteLine("The result is {0}\n", result);
                            do
                            {
                                Console.Write("Restart ? ( Y or N )");
                                restartOperation = Convert.ToChar(Console.ReadLine().ToUpper());
                            } while (!(restartOperation == 'Y' || restartOperation == 'N'));
                            break;
                        default: break;
                    }
                } while (restartOperation == 'Y');
                Console.Clear();
            } while (restartOperation == 'N');
        }
    }
}
