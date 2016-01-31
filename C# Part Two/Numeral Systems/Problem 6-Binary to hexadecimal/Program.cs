using System;

namespace Problem_6_Binary_to_hexadecimal
{
    internal class Program
    {
        private static bool CheckNumber(string binNumber)
        {
            var check = true;
            foreach (char item in binNumber)
            {
                if (item > '1')
                {
                    check = false;
                }
            }
            return check;
        }

        private static void Main()
        {
            //Write a program to convert binary numbers to hexadecimal numbers (directly).

            Console.WriteLine("Enter number in binary representation:");
            var binaryNumber = Console.ReadLine();
            if (CheckNumber(binaryNumber))
            {
                Console.WriteLine("Hexdecimal number: {0}", Convert.ToInt64(binaryNumber, 2).ToString("X"));
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}