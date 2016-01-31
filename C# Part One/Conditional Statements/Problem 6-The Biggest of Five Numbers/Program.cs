using System;

namespace Problem_6_The_Biggest_of_Five_Numbers
{
    internal class Program
    {
        private static void Main()
        {
            //Write a program that finds the biggest of five numbers by using only five if statements.

            var array = new double[3];
            double biggestNumber = 0;

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number:");
                var isNumber = double.TryParse(Console.ReadLine(), out array[i]);
                if (isNumber == false)
                {
                    Console.WriteLine("Is not a number!");
                    break;
                }
                if (biggestNumber < array[i])
                {
                    biggestNumber = array[i];
                }
            }
            Console.WriteLine("The biggest number is:{0}", biggestNumber);
        }
    }
}