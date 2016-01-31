using System;
using System.Linq;

namespace Problem_13_Solve_tasks
{
    internal class Program
    {
        private static void Equation()
        {
            double A, B;
            Console.WriteLine("Enter number A:");
            var isA = double.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Enter number B:");
            var isB = double.TryParse(Console.ReadLine(), out B);
            if (isA && isB && A != 0)
            {
                var result = -B/A;
                Console.WriteLine("result of the equation is: {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid entry for A or B!");
                PrintMenue();
            }
        }

        private static void PrintMenue()
        {
            Console.WriteLine("Press 1: to reverses the digits of a number");
            Console.WriteLine("Press 2: to calculates the average of a sequence of integers");
            Console.WriteLine("Press 3: to solves a linear equation a * x + b = 0");
            Console.WriteLine();
            Console.WriteLine("Enter your chois:");
            var chois = int.Parse(Console.ReadLine());
            if (chois == 1)
            {
                ReverseNUmbers();
            }
            else if (chois == 2)
            {
                Average();
            }
            else
            {
                Console.WriteLine("Invalid entry!");
                PrintMenue();
            }
        }

        private static void Average()
        {
            Console.WriteLine("Enter length of the sequence:");
            int length;
            var isLength = int.TryParse(Console.ReadLine(), out length);
            if (isLength)
            {
                var stringArray = new string[length];
                for (var i = 0; i < stringArray.Length; i++)
                {
                    Console.WriteLine("Enter member:");
                    stringArray[i] = Console.ReadLine();
                }
                var average = stringArray.Average(x => x.Length);
                Console.WriteLine("The average is:{0}", average);
            }
            else
            {
                Console.WriteLine("Invalid length!");
                PrintMenue();
            }
        }

        private static void ReverseNUmbers()
        {
            Console.WriteLine("Enter a number to reverse:");
            int intNumber;

            var isNumber = int.TryParse(Console.ReadLine(), out intNumber);
            if (isNumber)
            {
                var stringNumber = Convert.ToString(intNumber);
                var charArray = stringNumber.ToCharArray();
                for (var i = charArray.Length - 1; i >= 0; i--)
                {
                    if (i == charArray.Length - 1)
                    {
                        Console.Write("{" + charArray[i]);
                    }
                    else if (i == 0)
                    {
                        Console.Write("," + charArray[i] + "}");
                    }
                    else
                    {
                        Console.Write("," + charArray[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid entry for number!");
                PrintMenue();
            }
        }

        private static void Main()
        {
            /*
            Write a program that can solve these tasks:
            Reverses the digits of a number
            Calculates the average of a sequence of integers
            Solves a linear equation a * x + b = 0
            Create appropriate methods.
            Provide a simple text-based menu for the user to choose which task to solve.
            Validate the input data:
            The decimal number should be non-negative
            The sequence should not be empty
            a should not be equal to 0
            */

            PrintMenue();
        }
    }
}