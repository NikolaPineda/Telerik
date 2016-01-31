using System;

namespace Problem_2_Binary_to_decimal
{
    internal class Program
    {
        private static int Pow(int index)
        {
            var num = 1;
            for (var i = index - 1; i >= 0; i--)
            {
                num = num*2;
            }
            return num;
        }

        private static void Main()
        {
            //Write a program to convert binary numbers to their decimal representation.

            Console.WriteLine("Enter binary number:");
            var binaryNumber = Console.ReadLine();
            var checkBinary = true;
            if (binaryNumber != null)
            {
                foreach (char item in binaryNumber)
                {
                    if (item != '1' && item != '0')
                    {
                        checkBinary = false;
                    }
                }
                if (checkBinary)
                {
                    var sum = 0;
                    var charArray = binaryNumber.ToCharArray();
                    Array.Reverse(charArray);
                    for (var i = binaryNumber.Length - 1; i >= 0; i--)
                    {
                        sum += Pow(i)*Convert.ToInt32(charArray[i].ToString());
                    }
                    Console.WriteLine("The number is:{0}", sum);
                }
                else
                {
                    Console.WriteLine("Invalid entry!");
                }
            }
        }
    }
}