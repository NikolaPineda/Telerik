using System;
using System.Numerics;

namespace Problem_10_N_Factorial
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program to calculate n! for each n in the range [1..100].

            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine("Factorial for {0} is:{1}", i, Factorial(i));
            }
        }

        private static BigInteger Factorial(int index)
        {
            BigInteger factorial = 1;
            for (var i = 1; i <= index; i++)
            {
                factorial = factorial*i;
            }
            return factorial;
        }
    }
}