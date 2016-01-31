using System;

namespace Problem_5___Max_increasing_sequence
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that finds the maximal increasing sequence in an array.

            var counter = 1;
            var maxCounter = 0;
            var numberOfmaxCounter = 0;
            Console.WriteLine("Enter a number:");
            var lenght = int.Parse(Console.ReadLine());
            var array = new int[lenght];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] == 1)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    numberOfmaxCounter = array[i];
                }
            }
            if (maxCounter == 1)
            {
                Console.WriteLine("There are no sequences!");
            }
            else
            {
                for (var i = maxCounter; i > 0; i--)
                {
                    if (i == maxCounter)
                    {
                        Console.Write("{" + (numberOfmaxCounter - i + 1));
                    }
                    else if (i == 1)
                    {
                        Console.Write("," + (numberOfmaxCounter - i + 1) + "}");
                    }
                    else
                    {
                        Console.Write("," + (numberOfmaxCounter - i + 1));
                    }
                }
            }
        }
    }
}