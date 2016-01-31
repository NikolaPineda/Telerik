using System;
using System.Collections.Generic;

namespace Problem_15___Sieve_of_Eratosthenes
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

            long number = 10000000;
            var check = new bool[number];
            var listOfPrimes = new List<long>();
            for (var i = 0; i < check.Length; i++)
            {
                check[i] = true;
            }
            long j = 0;
            for (long i = 2; i < check.Length; i++)
            {
                if (check[i])
                {
                    listOfPrimes.Add(i);
                    j = i*i;
                }
                while (j < check.Length)
                {
                    check[j] = false;
                    j = j + i;
                }
            }
            foreach (long item in listOfPrimes)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}