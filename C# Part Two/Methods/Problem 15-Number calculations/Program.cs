using System;
using System.Linq;

namespace Problem_15_Number_calculations
{
    class Program
    {
        static T Product<T>(T[] array)
        {
            T product = default(T);
            for (int i = 0; i < array.Length; i++)
            {
                product *= (dynamic)array[i];
            }
            return product;
        }
        static T Minimal<T>(params T[] array)
        {
            T minimalNumber = array.Min();
            return minimalNumber;
        }

        static T Maximal<T>(params T[] array)
        {
            T maximalNumber = array.Max();
            return maximalNumber;
        }
        static T Average<T>(params T[] array)
        {
            T sum = default(T);
            for (int i = 0; i < array.Length; i++)
            {
                sum += (dynamic)array[i];
            }
            T average = (dynamic)array.Length;
            return average;
        }
        static T Sum<T>(params T[] array)
        {

            T sum = default(T);
            foreach (T item in array)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        static void Main()
        {
            /*
            Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
            Use generic method (read in Internet about generic methods in C#).
            */

            Console.WriteLine("Enter a length for the array:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
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
