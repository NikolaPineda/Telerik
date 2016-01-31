using System;

namespace Homework_Operators_and_Expressions
{
    internal class Program
    {
        private static void Main()
        {
            //Write an expression that checks if given integer is odd or even.

            int number;
            var isNumber = int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine("Enter a number:");

            if (isNumber)
            {
                if (number%2 == 0)
                {
                    Console.WriteLine("The number is even!");
                }
                else
                {
                    Console.WriteLine("The number is  odd!");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}