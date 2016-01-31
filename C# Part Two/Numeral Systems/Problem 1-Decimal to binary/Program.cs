using System;
using System.Collections.Generic;

namespace Problem_1_Decimal_to_binary
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program to convert decimal numbers to their binary representation.

            Console.WriteLine("Enter a number:");
            int number;
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                var list = new List<string>();
                while (number > 0)
                {
                    var newElement = number%2;
                    number = number/2;
                    list.Add(Convert.ToString(newElement));
                }
                list.Reverse();
                foreach (string item in list)
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