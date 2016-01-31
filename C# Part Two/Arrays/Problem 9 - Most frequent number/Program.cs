using System;
using System.Collections.Generic;

namespace Problem_9___Most_frequent_number
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that finds the most frequent number in an array.

            Console.WriteLine("Enter a lenght:");
            int count = 0, maxCount = 0;
            var listMax = 0;
            var lenght = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (var i = 0; i < lenght; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 0; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        count++;
                    }
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    listMax = list[i];
                }
                count = 0;
            }
            Console.WriteLine("Number {0} is within the sequence {1} times", listMax, maxCount);
        }
    }
}