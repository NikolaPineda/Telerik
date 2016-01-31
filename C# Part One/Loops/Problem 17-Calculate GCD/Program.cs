using System;

namespace Problem_17_Calculate_GCD
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
            */

            int a, b;
            Console.WriteLine("Enter a number:");
            var isA = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter a number:");
            var isB = int.TryParse(Console.ReadLine(), out b);
            if (isA && isB && a > 0 && b > 0)
            {
                var reminder = a%b;
                while (a%b != 0)
                {
                    a = b;
                    b = reminder;
                    reminder = a%b;
                }
                Console.WriteLine(Math.Abs(b));
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}