using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reverses the words in given sentence.
namespace Problem_13_Reverse_sentence
{
    class ReverseSentence
    {
        static readonly char[] operators = { '!', ',', ':', '/' };
        static string TextInsertSpace(string textInput) 
        {
            StringBuilder newText = new StringBuilder();
            List<int>positions = new List<int>();
            newText.Append(textInput);
            for (int i = 0; i < newText.Length; i++)
            {
                for (int j = 0; j < operators.Length; j++)
                {
                    if (newText[i] == operators[j])
                    {
                        positions.Add(i);
                    }
                }
            }
            for (int i = 0; i < positions.Count; i++)
            {
                newText.Insert(positions[i] + i, ' ');
            }
            string output = newText.ToString();
            return output;
        }
        static void ReverseWords(string text)
        {
            string[] newText = text.Split(' ');
            int check = 1;
            for (int i = newText.Length-2; i >= 0; i--)
            {
                
                for (int j = 0; j < operators.Length; j++)
                {
                    if (newText[i] == operators[j].ToString())
                    {
                        check = 1;
                    }
                }
                if (check == 1)
                {
                    Console.Write(newText[i]);
                }
                else
                {
                    Console.Write(" " + newText[i]);
                }
                check = 0;
            }
            Console.Write(newText[newText.Length-1]);
        }
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string textInput = Console.ReadLine();
            ReverseWords(TextInsertSpace(textInput));
        }
    }
}
