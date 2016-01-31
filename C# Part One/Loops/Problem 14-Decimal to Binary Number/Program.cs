using System;

namespace Problem_14_Decimal_to_Binary_Number
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Using loops write a program that converts an integer number to its binary representation.
            The input is entered as long. The output should be a variable of type string.
            Do not use the built-in .NET functionality.
            */

            var decNumber = long.Parse(Console.ReadLine());
            var binNumber = "";
            while (decNumber != 0)
            {
                var remain = (int) decNumber%2;
                decNumber /= 2;
                binNumber = remain + binNumber;
            }
            Console.WriteLine(binNumber);
        }
    }
}