using System;
namespace calc_project2
{
    class Func
    {
        public void displayTitle(string title, string subTitle)
        {
            Console.WriteLine("\t{0}", title.ToUpper());
            Console.WriteLine("\t" + new string('`', title.Length));
            Console.WriteLine("\t{0}\n", subTitle.ToUpper());
        }

        public void displayMenu()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Square");
            Console.WriteLine("6. Quit");
        }

        public ushort readOption(ushort min, ushort max)
        {
            ushort option = 0;
            do
            {
                try
                {
                    Console.Write("Enter your choice ({0} - {1}) : ", min, max);
                    option = Convert.ToUInt16(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nOnly no's between ({0} - {1}) are allowed\n", min, max);
                }
                Console.WriteLine(option);
            } while (option < min || option > max);
            Console.Clear();
            return option;
        }

        public double readValue(string temp)
        {
            double value = 0;
            do
            {
                try
                {
                    Console.Write(temp);
                    value = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("\nEnter only numeric values");
                }
            } while (value < 0);
            return value;
        }

        public double calcAdd(string operation)
        {
            double result = 0;
            displayTitle("calculator 2", " - " + operation + " -");
            short NBValues = Convert.ToInt16(readValue("Enter the no. of value for " + operation + " : "));
            for (short i = 0; i < NBValues; i++)
            {
                result += readValue("Enter value " + (i + 1) + " : ");
            }
            return result;
        }
        public double calcSub(string operation)
        {
            displayTitle("calculator 2.0", " - " + operation + " -");
            return readValue("Enter value 1 : ") - readValue("Enter value 2 : ");
        }

        public double calcMul(string operation)
        {
            double result = 1;
            displayTitle("calculator 2.0", " - " + operation + " -");
            short NBValues = Convert.ToInt16(readValue("Enter the no. of values for " + operation + " : "));
            for (short i = 0; i < NBValues; i++)
            {
                result *= readValue("Enter value " + (i + 1) + " : ");
            }
            return result;
        }

        public double calcDiv(string operation)
        {
            displayTitle("calculator 2.0", " - " + operation + " -");
            return readValue("Enter the value to divide  : ") / readValue("Enter the divider : ");
        }

        public double calcSquare(string operation)
        {
            double value;
            displayTitle("calculator 2.0", " - " + operation + " -");
            value = readValue("Enter a value : ");
            return value * value;
        }

        public void displayResult(double result)
        {
            Console.WriteLine("The result is {0}", result);
        }

        public char restartCalc(char restart)
        {
            do
            {
                Console.Write("Would you like to do another  ? (y - n) : ");
                restart = Convert.ToChar(Console.ReadLine().ToUpper());
            } while (!(restart == 'Y' || restart == 'N'));
            Console.Clear();
            return restart;
        }
    }
}
