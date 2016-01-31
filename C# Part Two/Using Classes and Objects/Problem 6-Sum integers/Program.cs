using System;
using System.Linq;

namespace Problem_6_Sum_integers
{
    internal class Program
    {
        /*
        You are given a sequence of positive integer values written into a string, separated by spaces.
        Write a function that reads these values from given string and calculates their sum.
        */

        private static void Main()
        {
            Console.WriteLine("Enter sequence of positive number separated by space:");
            var numbers = Console.ReadLine();
            CheckEntry(numbers);
            CounterOfNumbers(numbers);
        }

        private static void CounterOfNumbers(string numbers)
        {
            var arrayNumbers = numbers.Split(' ').Select(x => int.Parse(x)).ToArray();
            var sum = 0;
            foreach (int item in arrayNumbers)
            {
                sum += item;
            }
            Console.WriteLine("Sum is: {0}", sum);
        }

        private static void CheckEntry(string numbers)
        {
            var check = true;
            foreach (char item in numbers)
            {
                if (item > '9' && item != ' ')
                {
                    check = false;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Invalid entry!");
                Main();
            }
        }
    }
}