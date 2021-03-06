﻿using System;

namespace Problem_16_Decimal_to_Hexadecimal_Number
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Using loops write a program that converts an integer number to its hexadecimal representation.
            The input is entered as long. The output should be a variable of type string.
            Do not use the built-in .NET functionality.
            */

            var decNumber = long.Parse(Console.ReadLine());
            var hexNumber = "";
            if (decNumber == 0)
            {
                hexNumber = "0";
            }
            else
            {
                while (decNumber > 0)
                {
                    var remain = decNumber%16;
                    decNumber /= 16;
                    switch (remain)
                    {
                        case 10:
                            hexNumber = "A" + hexNumber;
                            break;
                        case 11:
                            hexNumber = "B" + hexNumber;
                            break;
                        case 12:
                            hexNumber = "C" + hexNumber;
                            break;
                        case 13:
                            hexNumber = "D" + hexNumber;
                            break;
                        case 14:
                            hexNumber = "E" + hexNumber;
                            break;
                        case 15:
                            hexNumber = "F" + hexNumber;
                            break;
                        default:
                            hexNumber = remain + hexNumber;
                            break;
                    }
                }
            }
            Console.WriteLine(hexNumber);
        }
    }
}