using System;

namespace Problem_7_Reverse_number
{
    internal class Program
    {
        private static decimal Reversed(decimal num)
        {
            var number = Convert.ToString(num);
            var charArray = number.ToCharArray();
            Array.Reverse(charArray);
            number = new string(charArray);
            num = decimal.Parse(number);
            return num;
        }

        private static void Main()
        {
            //Write a method that reverses the digits of given decimal number.

            Console.WriteLine("Enter a number:");
            var num = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Reversed(num));
        }
    }
}