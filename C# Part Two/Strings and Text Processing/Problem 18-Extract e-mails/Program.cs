using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_18_Extract_e_mails
{
    internal class ExtractMails
    {
        //Write a program for extracting all email addresses from given text.
        //All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
        private static void Main()
        {
            Console.WriteLine("Enter text:");
            var text = Console.ReadLine();
            if (text != null)
            {
                var words = text.Split(',', ' ', '"');
                var eMails = new List<string>();
                foreach (var word in words)
                {
                    if (word.Contains('@'))
                    {
                        eMails.Add(word);
                    }
                }
                foreach (string item in eMails)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}