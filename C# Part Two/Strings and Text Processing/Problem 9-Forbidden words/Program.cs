using System;
using System.Collections.Generic;

namespace Problem_9_Forbidden_words
{
    internal class ForbiddenWords
    {
        /*
        We are given a string containing a list of forbidden words and a text containing some of these words.
        Write a program that replaces the forbidden words with asterisks.
            */
        private static void TrimOfWords(List<string> words, string sentence)
        {
            var newSentence = sentence.Split(new[] {',', '.', ' ', '!'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in words)
            {
                for (var j = 0; j < newSentence.Length; j++)
                {
                    if (item == newSentence[j])
                    {
                        newSentence[j] = newSentence[j].Replace(item, new string('*', item.Length));
                        newSentence[j] = ' ' + newSentence[j] + ' ';
                    }
                }
            }
            var text = newSentence.ToString();
            foreach (char item in text)
            {
                Console.Write(item);
            }
        }

        private static void Main()
        {
            Console.WriteLine("Enter lenth of forbidden words:");
            var length = int.Parse(Console.ReadLine());
            var words = new List<string>();
            for (var i = 0; i < length; i++)
            {
                Console.WriteLine("Enter word:");
                words.Add(Console.ReadLine());
            }
            Console.WriteLine("Enter sentence:");
            var sentence = Console.ReadLine();

            TrimOfWords(words, sentence);
        }
    }
}