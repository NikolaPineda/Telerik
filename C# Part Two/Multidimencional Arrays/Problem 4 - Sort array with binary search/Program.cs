using System;

namespace Problem_4___Sort_array_with_binary_search
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program, that reads from the console an array of N integers and an integer K,
            sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
            */

            Console.WriteLine("Enter lenght for the array:");
            var lenght = int.Parse(Console.ReadLine());
            var array = new int[lenght];
            for (var i = 0; i < lenght; i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter K number:");
            var k = int.Parse(Console.ReadLine());
            Array.Sort(array);
            Console.WriteLine(Array.BinarySearch(array, k));
        }
    }
}