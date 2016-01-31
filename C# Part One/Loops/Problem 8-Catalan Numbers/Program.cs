using System;
using System.Numerics;

namespace Problem_8_Catalan_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

            BigInteger factorial = 1, factorial2 = 1, factorial3 = 1;
            int n;
            Console.WriteLine("Please enter your number: ");
            var isN = int.TryParse(Console.ReadLine(), out n);
            if (isN && n >= 0)
            {
                for (var i = 1; i <= n; i++)
                {
                    factorial = factorial*i;
                }
                for (var j = 1; j <= n + 1; j++)
                {
                    factorial2 = factorial2*j;
                }
                for (var k = 1; k <= 2*n; k++)
                {
                    factorial3 = factorial3*k;
                }
                var result = factorial3/(factorial2*factorial);
                Console.WriteLine("The result is equal to:{0}", result);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}