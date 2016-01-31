using System;

namespace Problem_14_Modify_a_Bit_at_Given_Position
{
    internal class Program
    {
        private static void Main()
        {
            /*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/

            int number, bitNumber;
            Console.WriteLine("Enter number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Enter a bit position:");
            var isBitNumber = int.TryParse(Console.ReadLine(), out bitNumber);

            if (isNumber && isBitNumber)
            {
                var mask = 1 << bitNumber;
                var numberMask = number & mask;
                var bit = numberMask >> bitNumber;
                int result;
                if (bit == 1)
                {
                    var newMask = ~(1 << bitNumber);
                    result = number & newMask;
                    Console.WriteLine("The resul is equal to:{0}", result);
                }
                else if (bit == 0)
                {
                    result = number | mask;
                    Console.WriteLine("The result is equal to:{0}", result);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}