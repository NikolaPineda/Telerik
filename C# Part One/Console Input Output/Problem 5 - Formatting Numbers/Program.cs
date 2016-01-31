using System;

namespace Problem_5___Formatting_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that reads 3 numbers:
            integer a (0 <= a <= 500)
            floating-point b
            floating-point c
            The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            The number a should be printed in hexadecimal, left aligned
            Then the number a should be printed in binary form, padded with zeroes
            The number b should be printed with 2 digits after the decimal point, right aligned
            The number c should be printed with 3 digits after the decimal point, left aligned.*/

            int integerNumber;
            Console.WriteLine("Enter integer number:");
            var isIntegerNumber = int.TryParse(Console.ReadLine(), out integerNumber);
            float firstFloatiogPointNumber, secondFloatingPointNumber;
            Console.WriteLine("Enter floating point number:");
            var isFloatingPointFirst = float.TryParse(Console.ReadLine(), out firstFloatiogPointNumber);
            Console.WriteLine("Enter floating point number:");
            var isFloatingPointSecond = float.TryParse(Console.ReadLine(), out secondFloatingPointNumber);

            if (isIntegerNumber && isFloatingPointFirst && isFloatingPointSecond && integerNumber >= 0 && integerNumber <= 500)
            {
                var hex = integerNumber.ToString("x").PadLeft(10, ' ');
                var bin = Convert.ToString(integerNumber, 2).PadLeft(10, '0');
                var bToString = firstFloatiogPointNumber.ToString().PadRight(10, ' ');
                var cToString = secondFloatingPointNumber.ToString().PadLeft(10, ' ');

                Console.Write(hex + "|");
                Console.Write(bin + "|");
                Console.Write("{0:0.00}|", bToString);
                Console.Write("{0:0.000}|", cToString);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}