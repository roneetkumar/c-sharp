using System;

namespace calc_project2
{
    class Program
    {
        static void Main(string[] args)
        {
            char restart;
            do
            {
                restart = '0';
                ushort choice;
                double result;
                var function = new Func();

                function.displayTitle("calculator 2", "- by roneet -");
                function.displayMenu();
                choice = function.readOption(1, 6);
                do
                {
                    switch (choice)
                    {
                        case 1:
                            result = function.calcAdd("addition");
                            function.displayResult(result);
                            restart = function.restartCalc(restart);
                            break;
                        case 2:
                            result = function.calcSub("subtract");
                            function.displayResult(result);
                            restart = function.restartCalc(restart);
                            break;
                        case 3:
                            result = function.calcMul("multiply");
                            function.displayResult(result);
                            restart = function.restartCalc(restart);
                            break;
                        case 4:
                            result = function.calcDiv("division");
                            function.displayResult(result);
                            restart = function.restartCalc(restart);
                            break;
                        case 5:
                            result = function.calcSquare("square");
                            function.displayResult(result);
                            restart = function.restartCalc(restart);
                            break;
                        default: break;
                    }
                } while (restart == 'Y');
            } while (restart == 'N');
        }
    }
}
