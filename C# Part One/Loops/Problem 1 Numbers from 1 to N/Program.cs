using System;

namespace Problem_1_Numbers_from_1_to_N
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.*/

            int number;
            Console.WriteLine("Enter number");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                for (var i = 1; i < number + 1; i++)
                {
                    Console.Write(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}