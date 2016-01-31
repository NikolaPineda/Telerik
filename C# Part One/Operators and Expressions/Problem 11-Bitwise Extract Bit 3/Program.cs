using System;

namespace Problem_11_Bitwise_Extract_Bit_3
{
    internal class Program
    {
        private static void Main()
        {
            /*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
                The bits are counted from right to left, starting from bit #0.
                The result of the expression should be either 1 or 0.*/

            int number;
            var bitThree = 3;
            Console.WriteLine("Enter a number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);

            if (isNumber)
            {
                var mask = 1 << bitThree;
                var numberMask = number & mask;
                var bit = numberMask >> bitThree;
                Console.WriteLine("The number og the third bit is:{0}", bit);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}