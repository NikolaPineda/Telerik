using System;

namespace Problem_9_Sorting_array
{
    internal class Program
    {
        private static void PrintNewArray(int[] newArray)
        {
            foreach (int item in newArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static int[] MaxNumber(int[] array, int[] newArray)
        {
            for (int i = 0, j = array.Length - newArray.Length; i < newArray.Length && j < array.Length; i++, j++)
            {
                newArray[i] = array[j];
            }
            Array.Sort(newArray);
            return newArray;
        }

        private static void Main()
        {
            /*
            Write a method that return the maximal element in a portion of array of integers starting at given index.
            Using it write another method that sorts an array in ascending / descending order.
            */

            Console.WriteLine("Enter lenght for the array:");
            var length = int.Parse(Console.ReadLine());
            var array = new int[length];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter a start number:");
            var startNumber = int.Parse(Console.ReadLine());
            var newArray = new int[length - startNumber];
            MaxNumber(array, newArray);
            PrintNewArray(newArray);
            Console.WriteLine("Max number is: {0}", newArray[newArray.Length - 1]);
            Array.Reverse(MaxNumber(array, newArray));
            PrintNewArray(newArray);
            Console.WriteLine(2%10);
        }
    }
}