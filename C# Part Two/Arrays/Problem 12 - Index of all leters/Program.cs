using System;

namespace Problem_12___Index_of_all_leters
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program that creates an array containing all letters from the alphabet (A-Z).
            Read a word from the console and print the index of each of its letters in the array.
            */

            var arrayChar = new char[26];
            for (var i = 0; i < arrayChar.Length; i++)
            {
                arrayChar[i] = (char) ('a' + i);
            }
            var word = Console.ReadLine().ToLower();
            foreach (var item in word)
            {
                for (var i = 0; i < arrayChar.Length; i++)
                {
                    if (item == arrayChar[i])
                    {
                        Console.WriteLine("The leter is {0} and it's number is: {1}", item, i);
                    }
                }
            }
        }
    }
}