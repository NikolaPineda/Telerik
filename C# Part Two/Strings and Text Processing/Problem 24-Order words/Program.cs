using System;

namespace Problem_24_Order_words
{
    internal class OrtherWords
    {
        /*
        Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
            */
        private static void Main()
        {
            Console.WriteLine("Enter text:");
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                var input = readLine.ToLower();
                var inputArray = input.Split(' ');
                Array.Sort(inputArray);
                foreach (string item in inputArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}