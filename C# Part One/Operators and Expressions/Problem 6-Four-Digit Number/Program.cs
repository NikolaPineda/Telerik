using System;

namespace Problem_6_Four_Digit_Number
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
                Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
                Prints on the console the number in reversed order: dcba (in our example 1102).
                Puts the last digit in the first position: dabc (in our example 1201).
                Exchanges the second and the third digits: acbd (in our example 2101).
                The number has always exactly 4 digits and cannot start with 0.*/

            Console.WriteLine("Enter four digit number:");
            int number;
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            var numberFour = number%10;
            var numberThree = number/10%10;
            var numberTwo = number/100%10;
            var numberOne = number/1000%10;

            if (isNumber && number > 9999 && number < 1000 && numberOne == 0)
            {
                var sum = numberOne + numberTwo + numberThree + numberFour;
                Console.WriteLine("Number - {0}", number);
                Console.WriteLine("Sum = {0}", sum);
                Console.WriteLine("Reversed - {0}{1}{2}{3}", numberFour, numberThree, numberTwo, numberOne);
                Console.WriteLine("Last digit in the first position - {0}{1}{2}{3}", numberFour, numberOne, numberTwo,
                    numberThree);
                Console.WriteLine("Exchanges second and the third digits - {0}{1}{2}{3}", numberOne, numberThree,
                    numberTwo, numberFour);
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}