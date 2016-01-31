using System;

namespace Problem_7_Calculate_N__K__N_K___
{
    internal class Program
    {
        private static void Main()
        {
            /*In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
            Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/

            double n, k;
            double factorialN = 1;
            double factorialK = 1;
            Console.WriteLine("Enter N number:");
            var isN = double.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Enter K number:");
            var isK = double.TryParse(Console.ReadLine(), out k);
            if (isK && isN && k > 1 && k < n && n < 100)
            {
                for (var i = 1; i <= n; i++)
                {
                    factorialN *= i;
                    if (i <= k)
                    {
                        factorialK *= i;
                    }
                }
                var result = factorialN/(factorialK*(n - k));
                Console.WriteLine("Result is : {0}", result);
            }
            else
            {
                Console.WriteLine("Inavlid entry!");
            }
        }
    }
}