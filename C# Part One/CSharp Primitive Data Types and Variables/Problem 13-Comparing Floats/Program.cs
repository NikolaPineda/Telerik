using System;

namespace Problem_13_Comparing_Floats
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter number:");
            var firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number:");
            var secondNumber = double.Parse(Console.ReadLine());

            var difference = Math.Abs(firstNumber - secondNumber);
            var minDifference = 0.000001;
            var areEqual = difference < minDifference;
            Console.WriteLine(areEqual);
        }
    }
}