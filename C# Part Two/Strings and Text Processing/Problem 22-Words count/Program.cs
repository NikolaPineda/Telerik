using System;
using System.Collections.Generic;

namespace Problem_22_Words_count
{
    internal class Program
    {
        //Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
        private static void Main()
        {
            Console.WriteLine("Enter text");
            var text = Console.ReadLine();
            if (text != null)
            {
                var textArray = text.Split(new[] {'.', ' ', '!', '?', ','}, StringSplitOptions.RemoveEmptyEntries);
                var dictionary = new Dictionary<string, int>();
                foreach (string item in textArray)
                {
                    if (!dictionary.ContainsKey(item))
                    {
                        dictionary.Add(item, 1);
                    }
                    else if (dictionary.ContainsKey(item))
                    {
                        dictionary[item] += 1;
                    }
                }
                foreach (var pair in dictionary)
                {
                    Console.WriteLine("{0},{1}", pair.Key, pair.Value);
                }
            }
        }
    }
}