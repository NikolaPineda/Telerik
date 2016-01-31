using System;

namespace Problem_5_The_Biggest_of_3_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that finds the biggest of three numbers.

            var array = new double[3];
            double biggertNumber = 0;

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = double.Parse(Console.ReadLine());
                if (biggertNumber < array[i])
                {
                    biggertNumber = array[i];
                }
            }
            Console.WriteLine("The biggest number is:{0}", biggertNumber);
        }
    }
}