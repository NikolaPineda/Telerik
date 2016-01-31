using System;

namespace Problem_4___Max_sequence
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that finds the maximal sequence of equal elements in an array.

            Console.WriteLine("Enter lenght for the array:");
            var counter = 1;
            var maxCounter = 0;
            var numberOfMaxArray = 0;
            var lenght = int.Parse(Console.ReadLine());
            var array = new int[lenght];
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    numberOfMaxArray = array[i];
                }
            }
            for (var i = 0; i < maxCounter; i++)
            {
                if (i == 0)
                {
                    Console.Write("{" + numberOfMaxArray);
                }
                else if (i == maxCounter - 1)
                {
                    Console.Write(numberOfMaxArray + "}");
                }
                else
                {
                    Console.Write("," + numberOfMaxArray + ",");
                }
            }
        }
    }
}