using System;

namespace Problem_3_Divide_by_7_and_5
{
    internal class Program
    {
        private static void Main()
        {
            //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

            int number;
            Console.WriteLine("Enter a number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);

            if (isNumber)
            {
                if (number%5 == 0 && number%7 == 0)
                {
                    Console.WriteLine("The number can be devited by 7 and 5 is:{0}", true);
                }
                else
                {
                    Console.WriteLine("The number can be devited by 7 and 5 is:{0}", false);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}