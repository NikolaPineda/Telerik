using System;

namespace Problem_5_Third_Digit_is_7
{
    internal class Program
    {
        private static void Main()
        {
            //Write an expression that checks for given integer if its third digit from right-to-left is 7.

            int number;
            Console.WriteLine("Enter a Number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);

            if (isNumber)
            {
                if (number%1000 < 800 && number%1000 > 699)
                {
                    Console.WriteLine("The third digit is seven:{0}", true);
                }
                else
                {
                    Console.WriteLine("The third digit is seven:{0}", false);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}