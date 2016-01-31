using System;

namespace Problem_7___Sum_of_5_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

            var input = Console.ReadLine().Split(' ');
            var a = double.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);
            var d = double.Parse(input[3]);
            var e = double.Parse(input[4]);

            var sumOfAll = a + b + c + d + e;
            Console.WriteLine(sumOfAll);
        }
    }
}