using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problem_8_Number_as_array
{
    internal class Program
    {
        private static List<BigInteger> SumCounter(string firstNumber, string secondNumber)
        {
            var newList = new List<BigInteger>();
            var counter = 0;
            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else if (firstNumber.Length < secondNumber.Length)
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }
            for (var i = firstNumber.Length - 1; i >= 0; i--)
            {
                var tempSum = Convert.ToInt32(firstNumber[i].ToString()) + Convert.ToInt32(secondNumber[i].ToString()) +
                              counter;
                counter = tempSum > 9 ? 1 : 0;
                newList.Add(tempSum);
            }
            return newList;
        }

        private static bool Checker(string number)
        {
            var checkTrue = true;
            foreach (char item in number)
            {
                if (item > '9' || item < '0')
                {
                    checkTrue = false;
                }
            }
            if (checkTrue)
            {
                return true;
            }
            return false;
        }

        private static void Main()
        {
            /*
            Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
            Each of the numbers that will be added could have up to 10 000 digits.
            */

            Console.WriteLine("Enter first number:");
            var firstNumber = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            var secondNumber = Console.ReadLine();
            if (Checker(firstNumber) && Checker(secondNumber))
            {
                SumCounter(firstNumber, secondNumber);
                for (var i = SumCounter(firstNumber, secondNumber).Count - 1; i >= 0; i--)
                {
                    Console.Write(SumCounter(firstNumber, secondNumber)[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}