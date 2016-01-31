using System;

namespace Problem_6_First_larger_than_neighbours
{
    internal class Program
    {
        private static int Scaner(int[] array)
        {
            var index = 0;
            for (var i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    index = i;
                    break;
                }
            }
            if (index > 0)
            {
                return index;
            }
            return -1;
        }

        private static void Main()
        {
            /*
            Write a method that returns the index of the first element in array that is larger than its neighbours, 
            or -1, if there’s no such element.
            Use the method from the previous exercise.
            */

            Console.WriteLine("Enter a length for the array:");
            var length = int.Parse(Console.ReadLine());
            var array = new int[length];
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = int.Parse(Console.ReadLine());
            }
            if (Scaner(array) > 0)
            {
                Console.WriteLine("The index of the first bigger number in the array than its neighbors is {0}",
                    Scaner(array));
            }
            else if (Scaner(array) == -1)
            {
                Console.WriteLine("There is no element in the array that is larger than its neighbours");
            }
        }
    }
}