using System;

namespace Problem_7_Sort_3_Numbers_with_Nested_Ifs
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that enters 3 real numbers and prints them sorted in descending order.
            Use nested if statements.
            Note: Don’t use arrays and the built-in sorting functionality.*/

            double fistNumber, secondNumber, thirdNumber, small, bigger, biggest;
            Console.WriteLine("Enter first number:");
            var isFisrstNumber = double.TryParse(Console.ReadLine(), out fistNumber);
            Console.WriteLine("Enter second number:");
            var isSecondNumber = double.TryParse(Console.ReadLine(), out secondNumber);
            Console.WriteLine("Enter third number:");
            var isThirdNumber = double.TryParse(Console.ReadLine(), out thirdNumber);
            if (isFisrstNumber && isSecondNumber && isThirdNumber)
            {
                if (fistNumber > secondNumber && fistNumber > thirdNumber)
                {
                    biggest = fistNumber;
                    if (secondNumber > thirdNumber)
                    {
                        bigger = secondNumber;
                        small = thirdNumber;
                    }
                    else
                    {
                        bigger = thirdNumber;
                        small = secondNumber;
                    }
                    Console.WriteLine(small);
                    Console.WriteLine(bigger);
                    Console.WriteLine(biggest);
                }
                else if (secondNumber > fistNumber && secondNumber > thirdNumber)
                {
                    biggest = secondNumber;
                    if (fistNumber > thirdNumber)
                    {
                        bigger = fistNumber;
                        small = thirdNumber;
                    }
                    else
                    {
                        bigger = thirdNumber;
                        small = fistNumber;
                    }
                    Console.WriteLine(small);
                    Console.WriteLine(bigger);
                    Console.WriteLine(biggest);
                }
                else if (thirdNumber > fistNumber && thirdNumber > secondNumber)
                {
                    biggest = thirdNumber;
                    if (secondNumber > fistNumber)
                    {
                        bigger = secondNumber;
                        small = fistNumber;
                    }
                    else
                    {
                        bigger = fistNumber;
                        small = secondNumber;
                    }
                    Console.WriteLine(small);
                    Console.WriteLine(bigger);
                    Console.WriteLine(biggest);
                }
            }
        }
    }
}