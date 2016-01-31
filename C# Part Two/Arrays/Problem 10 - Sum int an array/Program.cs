using System;
using System.Collections.Generic;

namespace Problem_10___Sum_int_an_array
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present).

            Console.WriteLine("Enter a lenght:");
            var tempSum = 0;
            int currentCounter = 1, maxCounter = 1;
            var lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a sum:");
            var sum = int.Parse(Console.ReadLine());
            var list = new List<int>();
            var maxStart = 0;
            for (var i = 0; i < lenght; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (var i = 0; i < list.Count; i++)
            {
                for (var j = i; j < list.Count; j++)
                {
                    tempSum = tempSum + list[j];
                    if (tempSum < sum)
                    {
                        currentCounter++;
                    }
                    else if (tempSum == sum)
                    {
                        maxCounter = currentCounter;
                        maxStart = i + maxCounter;
                        break;
                    }
                }
                if (tempSum == sum)
                {
                    break;
                }
                tempSum = 0;
                currentCounter = 1;
            }
            if (tempSum == sum)
            {
                for (var i = maxStart - maxCounter; i < maxStart; i++)
                {
                    if (i == maxStart - maxCounter)
                    {
                        Console.Write("{" + list[i]);
                    }
                    else if (i == maxStart - 1)
                    {
                        Console.Write("," + list[i] + "}");
                    }
                    else
                    {
                        Console.Write("," + list[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("The array have not sequence equal to the sum!");
            }
        }
    }
}