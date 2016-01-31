using System;
using System.Collections.Generic;

namespace Problem_8___Find_biggest_sum_sequence
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that finds the sequence of maximal sum in given array.

            Console.WriteLine("Enter a lenght:");
            var lenght = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (var i = 0; i < lenght; i++)
            {
                Console.WriteLine("Enter a number:");
                var number = int.Parse(Console.ReadLine());
                list.Add(number);
            }
            int maxSum = list[0], currentSum = list[0];
            int currentStart = 0, maxStart = 0;
            int currentSequence = 1, maxSequence = 1;
            for (var i = 1; i < list.Count; ++i)
            {
                if (list[i] + currentSum > list[i])
                {
                    currentSum = list[i] + currentSum;
                    currentSequence++;
                }
                else
                {
                    currentSum = list[i];
                    currentSequence = 1;
                    currentStart = i;
                }
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    maxSequence = currentSequence;
                    maxStart = currentStart;
                }
            }
            for (var i = maxStart; i < maxStart + maxSequence; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}