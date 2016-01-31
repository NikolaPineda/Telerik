using System;
using System.Text;

//Write a program that reads a string, reverses it and prints the result at the console.

namespace Problem_2_Reverse_string
{
    internal class ReverseString
    {
        private static void Main()
        {
            Console.WriteLine("Enter some string sequence:");
            var input = Console.ReadLine();
            var bilderInput = new StringBuilder();
            for (var i = input.Length - 1; i >= 0; i--)
            {
                bilderInput.Append(input[i]);
            }
            input = bilderInput.ToString();
            Console.WriteLine(input);
        }
    }
}