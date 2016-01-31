using System;

namespace Problem_6_Calculate_N_K_
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
        Use only one loop.*/

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
                    factorialN = factorialN*i;
                    if (i <= k)
                    {
                        factorialK = factorialK*i;
                    }
                }
                var result = factorialN/factorialK;
                Console.WriteLine("Result = {0}", result);
            }
            else
            {
                Console.WriteLine("Inavlid entry!");
            }
        }
    }
}