using System;

namespace Problem_3_Day_of_week
{
    internal class Program
    {
        //Write a program that prints to the console which day of the week is today.
        private static void Main(string[] args)
        {
            var day = DateTime.Today;
            Console.WriteLine(day.ToString("dddddddd"));
        }
    }
}