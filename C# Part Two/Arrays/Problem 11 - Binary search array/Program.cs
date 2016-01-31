using System;
using System.Collections.Generic;

namespace Problem_11___Binary_search_array
{
    internal class Program
    {
        private static int Binarysearch(List<int> list, int elX)
        {
            list.Sort();
            var max = list.Count - 1;
            var min = 0;
            while (max >= min)
            {
                var midPiont = (max + min)/2;
                if (list[midPiont] > elX)
                {
                    max = midPiont - 1;
                }
                else if (list[midPiont] < elX)
                {
                    min = midPiont + 1;
                }
                else
                {
                    return midPiont;
                }
            }
            return -1;
        }

        private static void Main()
        {
            //Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

            Console.WriteLine("Enter  lenght of the array:");
            var lenght = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (var i = 0; i < lenght; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter element X:");
            var elX = int.Parse(Console.ReadLine());
            Console.WriteLine(Binarysearch(list, elX));
        }
    }
}