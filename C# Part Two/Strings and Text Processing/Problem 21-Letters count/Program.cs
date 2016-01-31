using System;
using System.Collections.Generic;

namespace Problem_21_Letters_count
{
    internal class LettersCount
    {
        //Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
        private static void Main()
        {
            Console.WriteLine("Enter string:");
            var input = Console.ReadLine().ToLower();
            var alpfhabet = "abcdefghijklmnopqrstuvwxyz";
            var dictionary = new Dictionary<string, int>();
            var counter = 0;
            foreach (char t in alpfhabet)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    if (t == input[j])
                    {
                        counter++;
                    }
                }
                if (counter != 0)
                {
                    dictionary.Add(t.ToString(), counter);
                    counter = 0;
                }
            }
            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }
        }
    }
}