using System;

namespace Problem_13_Check_a_Bit_at_Given_Position
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.*/

            int number, bitNumber;
            Console.WriteLine("Enter a number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Enter a bit position:");
            var isBitNumber = int.TryParse(Console.ReadLine(), out bitNumber);

            if (isBitNumber && isNumber)
            {
                var mask = 1 << bitNumber;
                var numberMask = number & mask;
                var bit = numberMask >> bitNumber;
                if (bit == 0)
                {
                    Console.WriteLine("The value of the bit {0} is zero:{1}", bitNumber, true);
                }
                else
                {                   
                    Console.WriteLine("The value of the bit {0} is 0:{1}", bitNumber, false);
                }
            }
        }
    }
}