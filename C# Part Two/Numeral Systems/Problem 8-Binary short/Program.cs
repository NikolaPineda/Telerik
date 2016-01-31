using System;

namespace Problem_8_Binary_short
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

            Console.WriteLine("Enter number:");
            var number = short.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToBinary(number));
        }

        private static string ConvertToBinary(int number)
        {
            string binary = null;
            for (var i = 15; i >= 0; i--)
            {
                binary = ((number%2) & 1) + binary;
                number >>= 1;
            }
            return binary;
        }
    }
}