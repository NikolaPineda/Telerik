using System;

namespace Problem_9_Matrix_of_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.*/

            int number;
            Console.WriteLine("Enter number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber && number >= 1 && number <= 20)
            {
                for (var i = 0; i < number; i++)
                {
                    for (var j = 1; j < number + 1; j++)
                    {
                        Console.Write(i + j > 9 ? "{0} " : "{0}  ", j + i);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}