using System;
using System.Text;

namespace Problem_25_Extract_text_from_HTML
{
    internal class ExtractText
    {
        /*
        Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
            */
        private static void Main()
        {
            var text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">
Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

            var sb = new StringBuilder();
            var isText = false;
            for (var i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == '<')
                {
                    isText = false;
                }
                if (isText)
                {
                    sb.Append(text[i]);
                }
                if (text[i] == '>')
                {
                    isText = true;
                    sb.Append(' ');
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}