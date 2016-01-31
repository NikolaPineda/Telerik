using System;

namespace Homework_1_Arrays
{
    internal class Program
    {
        private static void Main()
        {
            /*
            Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
            */

            var array = new int[20];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = i*5;
                Console.WriteLine(array[i]);
            }
        }
    }
}