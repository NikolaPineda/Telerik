using System;
using System.Collections.Generic;

namespace Problem_3_Decimal_to_hexadecimal
{
    internal class Program
    {
        private static char HexElement(int reminder)
        {
            var hex = '0';
            if (reminder >= 0 && reminder < 10)
            {
                hex = Convert.ToChar(reminder.ToString());
            }
            else
            {
                switch (reminder)
                {
                    case 10:
                        hex = 'A';
                        break;
                    case 11:
                        hex = 'B';
                        break;
                    case 12:
                        hex = 'C';
                        break;
                    case 13:
                        hex = 'D';
                        break;
                    case 14:
                        hex = 'E';
                        break;
                    case 15:
                        hex = 'F';
                        break;
                }
            }
            return hex;
        }

        private static void Main()
        {
            //Write a program to convert decimal numbers to their hexadecimal representation.

            Console.WriteLine("Enter a number:");
            int number;
            var list = new List<char>();
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                while (number > 0)
                {
                    var reminder = number%16;
                    number = number/16;
                    list.Add(HexElement(reminder));
                }
                list.Reverse();
                Console.Write("0x");
                foreach (char item in list)
                {
                    Console.Write(item);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}