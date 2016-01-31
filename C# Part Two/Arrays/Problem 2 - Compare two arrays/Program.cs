using System;

namespace Problem_2___Compare_two_arrays
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program that reads two integer arrays from the console and compares them element by element.
            */

            Console.WriteLine("Enter a lenght for the first array:");
            var firstLength = int.Parse(Console.ReadLine());
            var firstArray = new int[firstLength];
            for (var i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a lenght for the second array:");
            var secondLenght = int.Parse(Console.ReadLine());
            var secodnArray = new int[secondLenght];
            for (var i = 0; i < secodnArray.Length; i++)
            {
                secodnArray[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < Math.Min(firstArray.Length, secodnArray.Length); i++)
            {
                if (firstArray[i] < secodnArray[i])
                {
                    Console.WriteLine("Index {0} of  first array is smaller!", i);
                }
                else if (firstArray[i] > secodnArray[i])
                {
                    Console.WriteLine("Index {0} of  first array is bigger!", i);
                }
                else
                {
                    Console.WriteLine("The two indexs are equal!");
                }
            }
        }
    }
}