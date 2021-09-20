using System;

namespace console_calculator_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopCalculator loopCalc = new LoopCalculator();
            Console.Title = "Calculator";
            Console.ForegroundColor = ConsoleColor.Red;

            double num01;
            double num02;

            Console.WriteLine("Calculator");
            Console.WriteLine("List of opperations: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Choose the number next to the arithmetic operation you would like to do and enter it: ");
            string opperation = Console.ReadLine();
            bool continuePar = false;
            do
            {
                int choice;
                int.TryParse(opperation, out choice);

                if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
                {
                    continuePar = true;
                    Console.WriteLine("Input the first number: ");
                    num01 = check_num();

                    Console.WriteLine("Input the other number: ");
                    num02 = check_num();

                    double ans = sums(num01, num02, opperation);
                    Console.WriteLine("The answer is: " + ans);
                }
                else
                {
                    Console.WriteLine("You can only enter a number from the menu above!! Try again: ");
                    opperation = Console.ReadLine();
                }
            } while (continuePar == false);
            loopCalc.runLoop();

        }
        static int check_num()
        {
            int num;
            bool parseCheck = Int32.TryParse(Console.ReadLine(), out num);
            while (!parseCheck)
            {
                Console.WriteLine("You can only enter digits!! TRY AGAIN!!");
                parseCheck = Int32.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }



        static double sums(double num01, double num02, string opperation)
        {
            double ans = 0;
            if (opperation == "1")
            {
                ans = num01 + num02;
            }
            else if (opperation == "2")
            {
                ans = num01 - num02;
            }
            else if (opperation == "3")
            {
                ans = num01 * num02;
            }
            else if (opperation == "4")
            {
                ans = num01 / num02;
            }
            return ans;
        }
    }
}

