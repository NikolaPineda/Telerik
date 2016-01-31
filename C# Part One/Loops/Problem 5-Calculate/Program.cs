using System;

namespace Problem_5_Calculate
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/

            double n, x;
            double facturiel = 1;
            double sum = 1;
            Console.WriteLine("Enter the n number:");
            var isN = double.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Enter the x number:");
            var isX = double.TryParse(Console.ReadLine(), out x);
            if (isN && isX && n > 0 && 0 < x)
            {
                for (var i = 1; i <= n; i++)
                {
                    facturiel = facturiel*i;
                    var pow = Math.Pow(x, i);
                    var midSum = facturiel/pow;
                    sum += midSum;
                }
                Console.WriteLine("The sum is:{0:F5}", sum);
            }
            else
            {
                Console.WriteLine("Inavalid entry!");
            }
        }
    }
}