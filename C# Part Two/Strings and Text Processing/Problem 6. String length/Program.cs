using System;

namespace Problem_6.String_length
{
    //Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
    internal class StringLength
    {
        private static void Main()
        {
            Console.WriteLine("Enter text:");
            var input = Console.ReadLine();
            Console.WriteLine(input.Length <= 20 ? input.PadRight(20, '*') : "Your input is to long");
        }
    }
}