using System;

namespace Problem_13_Binary_to_Decimal_Number
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Using loops write a program that converts a binary integer number to its decimal form.
            The input is entered as string. The output should be a variable of type long.
            Do not use the built-in .NET functionality.
            */

            var binNumber = Console.ReadLine();
            long decNumber = 0;
            var power = 1;

            if (binNumber != null)
                for (var i = binNumber.Length - 1; i >= 0; i--)
                {
                    var num = binNumber[i] - 48;
                    decNumber += num*power;
                    power *= 2;
                }
            Console.WriteLine(decNumber);
        }
    }
}