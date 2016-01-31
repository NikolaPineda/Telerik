using System;

namespace Problem_14___Quicksort_algorithm
{
    internal class Program
    {
        private static int Quicksort(int[] array, int left, int right)
        {
            var pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    var temp = array[right];
                    array[right] = array[left];
                    array[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        private static void Recursive(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var pivot = Quicksort(arr, left, right);
                if (pivot > 1)
                {
                    Recursive(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Recursive(arr, pivot + 1, right);
                }
            }
        }

        private static void Main()
        {
            //Write a program that sorts an array of integers using the Merge sort algorithm.

            Console.WriteLine("Enter lenght for the array:");
            var lenght = int.Parse(Console.ReadLine());
            var unsortedArray = new int[lenght];
            for (var i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Quicksorted array");
            Recursive(unsortedArray, 0, lenght - 1);
            foreach (var item in unsortedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}