using System;

namespace Problem_4___Number_Comparer
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/

            double firstNumber, secondNumber;
            Console.WriteLine("Enter number:");
            var isNumber1 = double.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter number:");
            var isNumber2 = double.TryParse(Console.ReadLine(), out secondNumber);
            if (isNumber1 && isNumber2)
            {
                Console.WriteLine("The greather number is:{0}", Math.Max(firstNumber, secondNumber));
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}