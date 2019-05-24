using System;

namespace simpleCalc
{
    class Functions
    {
        public float add(float num1, float num2) => (float)Convert.ToDouble(num1 + num2);
        public float sub(float num1, float num2) => (float)Convert.ToDouble(num1 - num2);
        public float div(float num1, float num2) => (float)Convert.ToDouble(num1 / num2);
        public float mul(float num1, float num2) => (float)Convert.ToDouble(num1 * num2);
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            short select = 0;
            float num1, num2, result;
            Functions operation = new Functions();
            do
            {
                Console.WriteLine("\t--Calculator--\n");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("\nSelect Operation : ");
                select = operation.readNum("");
            } while (select < 1 || select > 6);
            Console.Clear();
            switch (select)
            {
                case 1:
                    Console.WriteLine("\t--Addition--");
                    num1 = operation.readNum("Enter num 1 : ");
                    num2 = operation.readNum("Enter num 2 : ");
                    result = operation.add(num1, num2);
                    Console.WriteLine("Answer : {0}", result);
                    break;
                case 2:
                    Console.WriteLine("\t--Subtraction--");
                    num1 = operation.readNum("Enter num 1 : ");
                    num2 = operation.readNum("Enter num 2 : ");
                    result = operation.sub(num1, num2);
                    Console.WriteLine("Answer : {0}", result);
                    break;
                case 3:
                    Console.WriteLine("\t--Multiplication--");
                    num1 = operation.readNum("Enter num 1 : ");
                    num2 = operation.readNum("Enter num 2 : ");
                    result = operation.mul(num1, num2);
                    Console.WriteLine("Answer : {0}", result);
                    break;
                case 4:
                    Console.WriteLine("\t--Division--");
                    num1 = operation.readNum("Enter num 1 : ");
                    num2 = operation.readNum("Enter num 2 : ");
                    result = operation.div(num1, num2);
                    Console.WriteLine("Answer : {0}", result);
                    break;
                default: break;
            }
        }
    }
}
