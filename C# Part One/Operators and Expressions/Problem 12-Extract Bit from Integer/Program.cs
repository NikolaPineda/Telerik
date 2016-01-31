using System;

namespace Problem_12_Extract_Bit_from_Integer
{
    internal class Program
    {
        private static void Main()
        {
            //Write an expression that extracts from given integer n the value of given bit at index p.

            int number, bitPosition;
            Console.WriteLine("Enter a number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Enter a  bit position:");
            var isBitPosition = int.TryParse(Console.ReadLine(), out bitPosition);

            if (isNumber && isBitPosition)
            {
                var mask = 1 << bitPosition;
                var numberMask = number & mask;
                var bit = numberMask >> bitPosition;
                Console.WriteLine("Bit is equal to:{0}", bit);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}