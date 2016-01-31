using System;

namespace Problem_3_Min_Max_Sum_and_Average_of_N_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
        The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
        The output is like in the examples below.*/

            Console.WriteLine("Enter number:");
            var lenght = int.Parse(Console.ReadLine());
            var min = int.MaxValue;
            var max = int.MinValue;
            decimal sum = 0;
            decimal avg = 0;
            for (var i = 0; i < lenght; i++)
            {
                Console.WriteLine("Enter number:");
                var numbers = int.Parse(Console.ReadLine());
                min = Math.Min(min, numbers);
                max = Math.Max(max, numbers);
                sum = sum + numbers;
                avg = sum/lenght;
            }
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Avg = {0:F2}", avg);
        }
    }
}