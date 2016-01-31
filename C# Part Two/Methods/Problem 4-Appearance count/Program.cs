using System;

namespace Problem_4_Appearance_count
{
    internal class Program
    {
        private static int MaxNumberRepeate(int[] array, int numberForCheck)
        {
            var counter = 0;
            foreach (int item in array)
            {
                if (numberForCheck == item)
                {
                    counter++;
                }
            }
            return counter;
        }

        private static void Main()
        {
            /*
            Write a method that counts how many times given number appears in given array.
            Write a test program to check if the method is workings correctly.
            */

            Console.WriteLine("Enter length for the array:");
            var length = int.Parse(Console.ReadLine());
            var array = new int[length];
            for (var i = 0; i < length; i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a nember for check:");
            var numberForCheck = int.Parse(Console.ReadLine());

            var counter = 0;
            foreach (int t in array)
            {
                if (numberForCheck == t)
                {
                    counter++;
                }
            }
            if (counter == MaxNumberRepeate(array, numberForCheck))
            {
                Console.WriteLine("The method is working correctly");
                Console.WriteLine("Number {0} has {1} repeates!", numberForCheck,
                    MaxNumberRepeate(array, numberForCheck));
            }
            else
            {
                Console.WriteLine("The method isn't working correcly");
            }
        }
    }
}