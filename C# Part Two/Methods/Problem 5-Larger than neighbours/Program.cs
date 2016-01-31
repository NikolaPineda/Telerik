using System;

namespace Problem_5_Larger_than_neighbours
{
    internal class Program
    {
        private static bool CheckForMathMax(int check, int[] array)
        {
            bool result = array[check - 1] > array[check - 2] && array[check - 1] > array[check];
            return result;
        }

        private static void Main()
        {
            /*
            Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
            */

            Console.WriteLine("Enter length for the array:");
            var length = int.Parse(Console.ReadLine());
            var array = new int[length];
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter number for check position < {0} and > 1:", length);
            var check = int.Parse(Console.ReadLine());
            if (check > 1 && check < length)
            {
                Console.WriteLine("The number is bigger than its neighbors: {0}", CheckForMathMax(check, array));
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}