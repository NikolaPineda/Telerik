using System;

namespace Problem_11_Number_as_Words
{
    internal class Program
    {
        private static void Hundreds(int number)
        {
            for (var i = 1; i < 10; i++)
            {
                if (number/100 == i)
                {
                    Digis(i);
                    Console.Write(" hundret");
                }
            }
        }

        private static void Tens(int number)
        {
            var tenToNinety = new[]
            {"ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            for (var i = 1; i < 10; i++)
            {
                if (number/10 == i)
                {
                    Console.Write(tenToNinety[i - 1] + " ");
                }
            }
        }

        private static void NumTo19(int number)
        {
            var numTo19 = new[]
            {"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            if (number > 10 && number < 20)
            {
                for (var i = 10; i < 20; i++)
                {
                    if (i == number)
                    {
                        Console.Write(numTo19[i - 11] + " ");
                    }
                }
            }
        }

        private static void Digis(int number)
        {
            var digits = new[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            if (number >= 0 & number < 10)
            {
                for (var i = 0; i < digits.Length; i++)
                {
                    if (i == number)
                    {
                        Console.Write(digits[i]);
                    }
                }
            }
        }

        private static void Main()
        {
            //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

            Console.WriteLine("Enter a number form 0 to 999;");
            int number;
            var isNumber = int.TryParse(Console.ReadLine(), out number);

            if (isNumber && number <= 999 && number >= 0)
            {
                int xMas;
                if (number/100 > 0)
                {
                    Hundreds(number);
                    xMas = number/100*100;
                    number = number - xMas;

                    if (number/10 == 1)
                    {
                        Console.Write(" and ");
                        NumTo19(number);
                    }
                    else if (number/10 > 1)
                    {
                        Console.Write(" and ");
                        Tens(number);
                        xMas = number/10*10;
                        number = number - xMas;
                        if (number == 0)
                        {
                        }
                        else
                        {
                            Console.Write(" ");
                            Digis(number);
                        }
                    }
                    else if (number - number/10 > 0)
                    {
                        number = number - number/10;
                        Console.Write(" and ");
                        Digis(number);
                    }
                }
                else if (number < 100 && number > 9)
                {
                    if (number/10 == 1)
                    {
                        NumTo19(number);
                    }
                    else if (number/10 > 1)
                    {
                        Tens(number);
                        xMas = number/10*10;
                        number = number - xMas;
                        if (number == 0)
                        {
                        }
                        else
                        {
                            Console.Write(" ");
                            Digis(number);
                        }
                    }
                }
                else
                {
                    Digis(number);
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}