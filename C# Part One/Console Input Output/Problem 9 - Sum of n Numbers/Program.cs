using System;

namespace Problem_9___Sum_of_n_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.*/

            int number;
            double sum = 0;
            Console.WriteLine("Enter number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                for (var i = 0; i < number; i++)
                {
                    Console.WriteLine("Enter number:");
                    var newNumber = double.Parse(Console.ReadLine());
                    sum += newNumber;
                }
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}