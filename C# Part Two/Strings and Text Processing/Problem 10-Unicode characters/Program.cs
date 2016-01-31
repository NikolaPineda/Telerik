using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
namespace Problem_10_Unicode_characters
{
    class UnicodeCharaccters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u"+ ((int)input[i]).ToString("X4"));
            }
        }
    }
}
