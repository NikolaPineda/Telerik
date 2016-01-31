using System;
using System.Numerics;

namespace Problem_4_Hexadecimal_to_decimal
{
    internal class Program
    {
        private static BigInteger Pow(int index)
        {
            BigInteger powNumber = 1;
            for (var i = 0; i < index; i++)
            {
                powNumber *= 16;
            }
            return powNumber;
        }

        private static int ReturnTrueNumber(char hex)
        {
            var num = 0;
            if (hex <= '9')
            {
                num = Convert.ToInt32(hex.ToString());
            }
            else
            {
                switch (hex)
                {
                    case 'A':
                        num = 10;
                        break;
                    case 'B':
                        num = 11;
                        break;
                    case 'C':
                        num = 12;
                        break;
                    case 'D':
                        num = 13;
                        break;
                    case 'E':
                        num = 14;
                        break;
                    case 'F':
                        num = 15;
                        break;
                }
            }
            return num;
        }

        private static bool CheckNumber(string hex)
        {
            var check = true;
            foreach (char item in hex)
            {
                if (item > 'F')
                {
                    check = false;
                }
            }
            return check;
        }

        private static void Main()
        {
            //Write a program to convert hexadecimal numbers to their decimal representation.

            Console.WriteLine("Enter a hexadecimal number:");
            var hex = Console.ReadLine();
            if (CheckNumber(hex))
            {
                if (hex != null)
                {
                    var charArray = hex.ToCharArray();
                    Array.Reverse(charArray);
                    BigInteger sum = 0;
                    for (var i = 0; i < charArray.Length; i++)
                    {
                        sum += ReturnTrueNumber(charArray[i])*Pow(i);
                    }
                    Console.WriteLine("The number in decimal is: {0}", sum);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}