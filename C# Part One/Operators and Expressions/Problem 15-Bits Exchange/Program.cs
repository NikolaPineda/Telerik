using System;

namespace Problem_15_Bits_Exchange
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

            Console.WriteLine("Enter a number:");
            var number = long.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            var position1 = 3;
            var position2 = 24;

            for (var i = 0; i < 3; i++)
            {
                var maskOne = (number & (1 << position1)) >> position1;
                var maskTwo = (number & (1 << position2)) >> position2;
                if (maskOne == 0 && maskTwo == 1)
                {
                    number = number | (1 << position1);
                    number = number & ~(1 << position2);
                }
                else if (maskOne == 1 && maskTwo == 0)
                {
                    number = number & ~(1 << position1);
                    number = number | (1 << position2);
                }
                position1++;
                position2++;
            }

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
        }
    }
}