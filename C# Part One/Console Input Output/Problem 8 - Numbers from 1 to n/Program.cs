using System;

namespace Problem_8___Numbers_from_1_to_n
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.*/

            Console.WriteLine("Enter a number");
            int number;
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                for (var i = 0; i < number; i++)
                {
                    Console.Write(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}