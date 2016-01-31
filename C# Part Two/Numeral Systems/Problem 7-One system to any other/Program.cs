using System;
using System.Collections.Generic;

namespace Problem_7_One_system_to_any_other
{
    internal class Program
    {
        private static int Case(char x)
        {
            var num = 0;
            switch (x)
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
            return num;
        }

        private static int Pow(int startSys, int index)
        {
            var num = 1;
            for (var i = 0; i < index; i++)
            {
                num = num*startSys;
            }
            return num;
        }

        private static int ToDecimal(string stringNumber, int startSys)
        {
            var sum = 0;
            var charArray = stringNumber.ToCharArray();
            Array.Reverse(charArray);
            for (var i = charArray.Length - 1; i >= 0; i--)
            {
                var number = charArray[i] <= '9' ? Convert.ToInt32(charArray[i].ToString()) : Case(charArray[i]);
                sum += number*Pow(startSys, i);
            }
            return sum;
        }

        private static char ConvertedElement(int reminder)
        {
            var x = '0';
            switch (reminder)
            {
                case 10:
                    x = 'A';
                    break;
                case 11:
                    x = 'B';
                    break;
                case 12:
                    x = 'C';
                    break;
                case 13:
                    x = 'D';
                    break;
                case 14:
                    x = 'E';
                    break;
                case 15:
                    x = 'F';
                    break;
            }
            return x;
        }

        private static void NewSys(int decimalNumber, int finalSys)
        {
            var list = new List<char>();

            while (decimalNumber > 0)
            {
                var reminder = decimalNumber%finalSys;
                decimalNumber = decimalNumber/finalSys;
                list.Add(reminder <= 9 ? Convert.ToChar(reminder.ToString()) : ConvertedElement(reminder));
            }
            Console.WriteLine("Converted: ");
            for (var i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i]);
            }
        }

        private static void Main()
        {
            //Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

            Console.WriteLine("Enter a number:");
            var stringNUmber = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter first numberal system:");
            var startSys = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second numeral system");
            var finalSys = int.Parse(Console.ReadLine());
            if (startSys > 1 && finalSys > 1 && startSys < 17 && finalSys < 17)
            {
                Console.WriteLine(ToDecimal(stringNUmber, startSys));
                Console.WriteLine();
                NewSys(ToDecimal(stringNUmber, startSys), finalSys);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
                Main();
            }
        }
    }
}