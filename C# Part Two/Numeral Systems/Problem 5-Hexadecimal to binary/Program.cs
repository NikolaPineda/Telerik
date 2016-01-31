using System;

namespace Problem_5_Hexadecimal_to_binary
{
    internal class Program
    {
        private static bool CheckNumber(string hexNumber)
        {
            var check = true;
            foreach (char item in hexNumber)
            {
                if (item > 'f')
                {
                    check = false;
                }
            }
            return check;
        }

        private static void Main()
        {
            //Write a program to convert hexadecimal numbers to binary numbers (directly).

            Console.WriteLine("Enter a number in hexdecimal representation");
            var hexNumber = Console.ReadLine();
            if (CheckNumber(hexNumber))
            {
                Console.WriteLine("The number in binary is: {0}", Convert.ToString(Convert.ToInt64(hexNumber, 16), 2));
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}