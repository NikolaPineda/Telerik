using System;

namespace Problem_2_Get_largest_number
{
    internal class Program
    {
        private static int GetMax(int firstNumber, int secondNumber)
        {
            var max = Math.Max(firstNumber, secondNumber);
            return max;
        }

        private static void Main()
        {
            /*
            Write a method GetMax() with two parameters that returns the larger of two integers.
            Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
            */

            Console.WriteLine("Enter fist number:");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter secondNumber:");
            var secondNUmber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter thirdNumber:");
            var thirdNumber = int.Parse(Console.ReadLine());
            var max = Math.Max(thirdNumber, GetMax(firstNumber, secondNUmber));
            Console.WriteLine("The biggest number is:{0}", max);
        }
    }
}