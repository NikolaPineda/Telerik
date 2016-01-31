using System;
using System.Linq;

namespace Problem_14_Integer_calculations
{
    internal class Program
    {
        private static int Product(int[] array)
        {
            var product = 1;
            for (var i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }

        private static int Minimal(params int[] array)
        {
            var minimalNumber = array.Min();
            return minimalNumber;
        }

        private static int Maximal(params int[] array)
        {
            var maximalNumber = array.Max();
            return maximalNumber;
        }

        private static double Average(params int[] array)
        {
            var average = array.Average();
            return average;
        }

        private static int Sum(params int[] array)
        {
            var sum = array.Sum();
            return sum;
        }

        private static void Main()
        {
            /*
            Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
            Use variable number of arguments.
            */

            Console.WriteLine("Enter a length for the array:");
            var length = int.Parse(Console.ReadLine());
            var array = new int[length];
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The minimal is: {0}", Minimal(array));
            Console.WriteLine("The maximal is: {0}", Maximal(array));
            Console.WriteLine("The average is: {0}", Average(array));
            Console.WriteLine("The sum of the array is: {0}", Sum(array));
            Console.WriteLine("The product is: {0}", Product(array));
        }
    }
}