using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8_Extract_sentences
{
    //Write a program that extracts from a given text all sentences containing given word.
    internal class ExtractSentences
    {
        private static List<string> ExtractorOfSentences(string textInput, string word)
        {
            var sentence = new StringBuilder();
            var check = false;
            var word1 = " " + word + " ";
            var word2 = " " + word + ".";
            var result = new List<string>();
            for (var i = 0; i < textInput.Length; i++)
            {
                if (textInput[i] == '.')
                {
                    sentence.Append(textInput[i]);
                    if (check)
                    {
                        result.Add(sentence.ToString());
                    }
                    check = false;
                    sentence.Clear();
                }
                else
                {
                    sentence.Append(textInput[i]);
                    if (i < textInput.Length - word1.Length + 1)
                    {
                        if (textInput.Substring(i, word1.Length) == word1 ||
                            textInput.Substring(i, word2.Length) == word2)
                        {
                            check = true;
                        }
                    }
                }
            }
            return result;
        }

        private static void PrintResult(List<string> result)
        {
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void Main()
        {
            Console.WriteLine("Enter text:");
            var textInput = Console.ReadLine();
            Console.WriteLine("Enter search word:");
            var word = Console.ReadLine();
            PrintResult(ExtractorOfSentences(textInput, word));
        }
    }
}