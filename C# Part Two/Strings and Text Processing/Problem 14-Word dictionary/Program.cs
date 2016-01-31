using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
namespace Problem_14_Word_dictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {".NET", "platform for applications from Microsoft"},
			    {"CLR", "managed execution environment for .NET"},
			    {"NAMESPACE", "hierarchical organization of classes"}
            };
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine().ToUpper();
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("{0}->{1}", word, dictionary[word]);
            }
            else
            {
                Console.WriteLine("Dictionary don't contain <{0}>", word);
            }
        }
    }
}
