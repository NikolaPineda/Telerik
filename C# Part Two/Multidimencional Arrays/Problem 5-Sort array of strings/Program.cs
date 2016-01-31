using System;

namespace Problem_5_Sort_array_of_strings
{
    internal class Program
    {
        private static void Sort(string[] arr)
        {
            Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void Main()
        {
            /*
            You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
            */

            Console.WriteLine("Enter a lenght of the array:");
            var lenght = int.Parse(Console.ReadLine());
            var array = new string[lenght];
            Console.WriteLine("Enter members for the array:");
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            Sort(array);
        }
    }
}