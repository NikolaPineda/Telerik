using System;
using System.Text;

namespace Problem_5_Parse_tags
{
    // You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.

    internal class ParseTags
    {
        private static string NewText(string text)
        {
            var bilderText = new StringBuilder();
            var startTag = "<upcase>";
            var stopTag = "</upcase>";
            var startUpper = 0;
            for (var i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    startUpper++;
                }
                if (i < text.Length - startTag.Length + 1)
                {
                    if (text.Substring(i, startTag.Length) == startTag)
                    {
                        i += startTag.Length;
                    }
                }
                if (i < text.Length - stopTag.Length + 1)
                {
                    if (text.Substring(i, stopTag.Length) == stopTag)
                    {
                        i += stopTag.Length;
                    }
                }
                if (startUpper%2 == 0)
                {
                    bilderText.Append(text[i]);
                }
                else
                {
                    bilderText.Append(text[i].ToString().ToUpper());
                }

                Console.WriteLine(startUpper);
            }
            var newText = bilderText.ToString();
            return newText;
        }

        private static void Main()
        {
            Console.WriteLine("Enter text:");
            var textInput = Console.ReadLine();
            Console.WriteLine(NewText(textInput));
        }
    }
}