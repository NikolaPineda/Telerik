using System;

// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

namespace Problem_4_Sub_string_in_text
{
    internal class SubStringInText
    {
        private static void Main()
        {
            var count = 0;
            Console.WriteLine("Please enter text:");
            var input = Console.ReadLine();
            Console.WriteLine("Enter text for searching:");
            var subText = Console.ReadLine();
            for (var i = 0; i < input.Length; i++)
            {
                if (i < input.Length - subText.Length + 1)
                {
                    if (input.Substring(i, subText.Length) == subText)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("/{0}/ is in your input {1} times!", subText, count);
        }
    }
}