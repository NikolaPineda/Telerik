using System;
using System.Linq;

namespace Problem_20_Palindromes
{
    internal class Palindromes
    {
        //Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
        private static void Main()
        {
            Console.WriteLine("Enter different words:\n");
            var input = Console.ReadLine();
            if (input != null)
            {
                var words = input.Split(new[] {',', ' ', '.', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var counter = 0;
                foreach (var word in words)
                {
                    if (IsPalindrome(word))
                    {
                        Console.WriteLine(" - " + word);
                        counter++;
                    }
                }
                Console.WriteLine(counter == 0
                    ? "There aren`t palindromes in the text!"
                    : "Those are the palindromes from the text");
            }
        }

        private static bool IsPalindrome(string word)
        {
            return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
        }
    }
}