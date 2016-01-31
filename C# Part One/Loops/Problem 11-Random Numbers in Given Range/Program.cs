using System;

namespace Problem_11_Random_Numbers_in_Given_Range
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/

            int n, min, max;
            Console.WriteLine("Enter min number:");
            var isMin = int.TryParse(Console.ReadLine(), out min);
            Console.WriteLine("Enter max number:");
            var isMax = int.TryParse(Console.ReadLine(), out max);
            Console.WriteLine("Enter length of numbers:");
            var isN = int.TryParse(Console.ReadLine(), out n);
            if (isMax && isMin && isN && max > min)
            {
                var random = new Random();
                for (var index = 0; index < n; index++)
                {
                    Console.Write("{0} ", random.Next(min, max + 1));
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}