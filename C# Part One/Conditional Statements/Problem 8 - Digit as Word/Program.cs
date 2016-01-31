using System;

namespace Problem_8___Digit_as_Word
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
            Print “not a digit” in case of invalid input.
            Use a switch statement.*/

            int digit;
            var isDigit = int.TryParse(Console.ReadLine(), out digit);
            if (isDigit)
            {
                switch (digit)
                {
                    case 0:
                        Console.WriteLine("Oero");
                        break;
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Is not a digit!");
            }
        }
    }
}