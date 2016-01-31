using System;
using System.Text;

namespace Problem_23_Series_of_letters
{
    internal class SeriesOfLeters
    {
        //Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
        private static void Main()
        {
            Console.WriteLine("Enter string:");
            var input = Console.ReadLine();
            var inputChange = new StringBuilder();
            var temp = string.Empty;
            if (input != null)
                foreach (char item in input)
                {
                    if (temp != item.ToString())
                    {
                        inputChange.Append(item.ToString());
                        temp = item.ToString();
                    }
                }
            input = inputChange.ToString();
            Console.WriteLine(input);
        }
    }
}