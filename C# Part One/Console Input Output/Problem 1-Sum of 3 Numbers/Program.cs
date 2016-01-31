using System;

namespace Problem_1_Sum_of_3_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that reads 3 real numbers from the console and prints their sum

            Console.WriteLine("Enter first number:");
            double firstNumber;
            var isFirstNumber = double.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter second number:");
            double secondNumber;
            var isSecondNumber = double.TryParse(Console.ReadLine(), out secondNumber);
            Console.WriteLine("Enter third number:");
            double thirdNumber;
            var isThirdNumber = double.TryParse(Console.ReadLine(), out thirdNumber);
            if (isFirstNumber && isSecondNumber && isThirdNumber)
            {
                var sum = firstNumber + secondNumber + thirdNumber;
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}