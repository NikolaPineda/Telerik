using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11_Dividable_by_Given_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            int counter = 0;
            Console.WriteLine("Enter first number:");
            bool isFirstNumber = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter second number:");
            bool isSecondNumber = int.TryParse(Console.ReadLine(), out secondNumber);
            if (isFirstNumber && isSecondNumber && firstNumber > 0 && secondNumber > 0)
            {
                int max = Math.Max(firstNumber, secondNumber);
                int min = Math.Min(firstNumber, secondNumber);
                for (int i = min; i  <= max; i ++)
                {
                    if (i % 5 == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("There are {0} divided by five:", counter);
            }
            Console.WriteLine("Invalid entry!");
        }
    }
}
