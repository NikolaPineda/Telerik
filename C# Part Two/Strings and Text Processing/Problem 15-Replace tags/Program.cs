using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
namespace Problem_15_Replace_tags
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string textInput = Console.ReadLine();
            string urlStart = "[URL=";
            string urlClose = "]";
            string urlEnd = "[/URL]";
            for (int i = 0; i < textInput.Length - 9; i++)
            {
                if (textInput.Substring(i, 9 ) == "<a href=\"")
                {
                    textInput = textInput.Replace("<a href=\"", urlStart);
                }
                if (textInput.Substring(i, 2) == "\">")
                {
                    textInput = textInput.Replace("\">", urlClose);
                }
                if (textInput.Substring(i, 4) == "</a>")
                {
                    textInput = textInput.Replace("</a>", urlEnd);
                }
            }
            Console.WriteLine(textInput);
        }
    }
}
