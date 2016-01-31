using System;

namespace Problem_4_Multiplication_Sign
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

            double number1, number2, number3;
            Console.WriteLine("Enter the first number:");
            var isNumber1 = double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter the second number:");
            var isNumber2 = double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Enter the third number:");
            var isNumber3 = double.TryParse(Console.ReadLine(), out number3);
            if (isNumber1 && isNumber2 && isNumber3)
            {
                var mathSing1 = Math.Sign(number1);
                var mathSing2 = Math.Sign(number2);
                var mathSing3 = Math.Sign(number3);
                if (number1 == 0 || number2 == 0 || number3 == 0)
                {
                    Console.WriteLine("The product of numbers is: 0");
                }
                else if (mathSing1 + mathSing2 + mathSing3 == -3)
                {
                    Console.WriteLine("Math sing is: -");
                }
                else if (mathSing1 + mathSing2 + mathSing3 == 3)
                {
                    Console.WriteLine("Math sing is: +");
                }
                else if (mathSing1 + mathSing2 + mathSing3 == -1)
                {
                    Console.WriteLine("Math sing is: +");
                }
                else if (mathSing1 + mathSing2 + mathSing3 == 1)
                {
                    Console.WriteLine("Math sing is: -");
                }
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}