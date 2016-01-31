using System;

namespace Problem_2_Numbers_Not_Divisible_by_3_and_7
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 or 7, on a single line, separated by a space.*/

            int number;
            Console.WriteLine("Enter number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                for (var i = 1; i < number + 1; i++)
                {
                    if (i%3 != 0 && i%7 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}