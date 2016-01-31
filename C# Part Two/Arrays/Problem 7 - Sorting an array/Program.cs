using System;

namespace Problem_7___Sorting_an_array
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
            Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
            find the smallest from the rest, move it at the second position, etc.
            */

            Console.WriteLine("Enter a number:");
            var lenght = int.Parse(Console.ReadLine());
            var array = new int[lenght];
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("Output!");
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}