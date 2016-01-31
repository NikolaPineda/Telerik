using System;
using System.Numerics;

namespace Problem_18_Trailing_Zeroes_in_N_
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
            */

            int number;
            BigInteger favtorial = 1;
            var numberOfZeros = 0;
            Console.WriteLine("Enter a number;");
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber && number > 0)
            {
                for (var i = 1; i <= number; i++)
                {
                    favtorial *= i;
                }
                Console.WriteLine(favtorial);
                if (number >= 5)
                {
                    do
                    {
                        var temp = number/5;
                        if (number/5 != 0)
                        {
                            numberOfZeros = numberOfZeros + temp;
                            number = temp;
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                }
                Console.WriteLine("Number of zeros is: {0}", numberOfZeros);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}