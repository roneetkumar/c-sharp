using System;

namespace simpleCalc
{
    class Functions
    {
        private float num1, num2, result;
        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }
        private float add() => (float)Convert.ToDouble(Num1 + Num2);
        private float sub() => (float)Convert.ToDouble(Num1 - Num2);
        private float div() => (float)Convert.ToDouble(Num1 / Num2);
        private float mul() => (float)Convert.ToDouble(Num1 * Num2);
        public byte readNum(string text)
        {
            bool test = false;
            byte num = 0;
            do
            {
                test = false;
                try
                {
                    Console.Write(text);
                    num = Convert.ToByte(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Only Numbers are allowed");
                    test = true;
                }
            } while (test);
            return num;
        }
        public void printResult(char operation)
        {
            float result = (operation == '+')
                ? add()
                    : (operation == '-')
                ? sub()
                    : (operation == '*')
                ? mul()
                    : div();
            Console.WriteLine("Answer : {0}", result);
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            short select = 0;
            Functions operation = new Functions();
            do
            {
                Console.Clear();
                Console.WriteLine("\t--Calculator--\n");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                select = operation.readNum("\nSelect Operation : ");
            } while (select < 1 || select > 5);
            Console.Clear();
            switch (select)
            {
                case 1:
                    Console.WriteLine("\t--Addition--");
                    operation.Num1 = operation.readNum("Enter num 1 : ");
                    operation.Num2 = operation.readNum("Enter num 2 : ");
                    operation.printResult('+');
                    break;
                case 2:
                    Console.WriteLine("\t--Subtraction--");
                    operation.Num1 = operation.readNum("Enter num 1 : ");
                    operation.Num2 = operation.readNum("Enter num 2 : ");
                    operation.printResult('-');
                    break;
                case 3:
                    Console.WriteLine("\t--Multiplication--");
                    operation.Num1 = operation.readNum("Enter num 1 : ");
                    operation.Num2 = operation.readNum("Enter num 2 : ");
                    operation.printResult('*');
                    break;
                case 4:
                    Console.WriteLine("\t--Division--");
                    operation.Num1 = operation.readNum("Enter num 1 : ");
                    operation.Num2 = operation.readNum("Enter num 2 : ");
                    operation.printResult('/');
                    break;
                default: break;
            }
        }
    }
}
