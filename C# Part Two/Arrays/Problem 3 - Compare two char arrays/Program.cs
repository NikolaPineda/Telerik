using System;

namespace Problem_3___Compare_two_char_arrays
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program that compares two char arrays lexicographically (letter by letter).
            */

            Console.WriteLine("Enter a lenght for the first array:");
            var firstLength = int.Parse(Console.ReadLine());
            var firstArray = new char[firstLength];
            var sum1 = '0';
            var sum2 = '0';
            for (var i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("Enter a char:");
                firstArray[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a lenght for the second array:");
            var secondLenght = int.Parse(Console.ReadLine());
            var secodnArray = new char[secondLenght];
            for (var i = 0; i < secodnArray.Length; i++)
            {
                Console.WriteLine("Enter a char");
                secodnArray[i] = char.Parse(Console.ReadLine());
            }
            for (var i = 0; i < Math.Min(firstArray.Length, secodnArray.Length); i++)
            {
                if (firstArray[i] > secodnArray[i])
                {
                    Console.WriteLine("The first array is bigger:");
                    break;
                }
                if (firstArray[i] < secodnArray[i])
                {
                    Console.WriteLine("The second array is bigger:");
                    break;
                }
                if (firstArray[i] == secodnArray[i])
                {
                    sum1 += firstArray[i];
                    sum2 += secodnArray[i];
                }
            }
            if (sum1 == sum2 && firstLength == secondLenght)
            {
                Console.WriteLine("The arrays are equal!");
            }
            else if (sum1 == sum2 && firstLength > secondLenght)
            {
                Console.WriteLine("First array is bigger");
            }
            else if (sum1 == sum2 && firstLength < secondLenght)
            {
                Console.WriteLine("First array is bigger");
            }
        }
    }
}