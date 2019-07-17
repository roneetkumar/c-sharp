using System;

namespace Exercise5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check;
            do
            {
                Console.Clear();
                check = false;
                try
                {
                    string letterGrade = "";
                    Console.Write("Enter any number : ");
                    double numberGrade = Convert.ToDouble(Console.ReadLine());

                    if (numberGrade >= 88)
                    {
                        letterGrade = "A";
                    }
                    else if (numberGrade >= 80 && numberGrade <= 87)
                    {
                        letterGrade = "B";
                    }
                    else if (numberGrade >= 68 && numberGrade <= 79)
                    {
                        letterGrade = "C";
                    }
                    else if (numberGrade >= 60 && numberGrade <= 67)
                    {
                        letterGrade = "D";
                    }
                    else
                    {
                        letterGrade = "F";
                    }

                    Console.WriteLine("Letter Grade is {0}", letterGrade);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    check = true;
                }
            } while (check);

        }
    }
}
