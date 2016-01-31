using System;

namespace Problem_2_Random_numbers
{
    internal class Program
    {
        //Write a program that generates and prints to the console 10 random values in the range [100, 200].
        private static readonly Random number = new Random();

        private static void Number()
        {
            var randomNumber = number.Next(100, 200);
            Console.Write(randomNumber + " ");
        }

        private static void Main()
        {
            for (var i = 0; i <= 20; i++)
            {
                Number();
            }
        }
    }
}