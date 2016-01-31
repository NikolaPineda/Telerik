using System;

namespace Problem_8_Prime_Number_Check
{
    internal class Program
    {
        private static void Main()
        {
            /*Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
              Note: You should check if the number is positive*/

            int number;
            var counter = 0;
            var check = false;
            Console.WriteLine("Enter a number:");
            var isNumber = int.TryParse(Console.ReadLine(), out number);

            if (isNumber && number <= 100 && number > 0)
            {
                for (var i = 1; i <= number; i++)
                {
                    if (number%i == 0)
                    {
                        counter++;
                        if (counter > 2)
                        {
                            Console.WriteLine("The number is prime:{0}", check);
                            break;
                        }
                    }
                }

                if (counter <= 2)
                {
                    check = true;
                    Console.WriteLine("The number is prime:{0}", check);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}