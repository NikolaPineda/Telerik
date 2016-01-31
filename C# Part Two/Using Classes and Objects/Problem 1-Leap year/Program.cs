using System;

namespace Problem_1_Leap_year
{
    internal class Program
    {
        //Write a program that reads a year from the console and checks whether it is a leap one.
        private static void Main()
        {
            Console.WriteLine("Enter year:");
            var year = Console.ReadLine();
            var checkEntry = true;
            if (year != null)
            {
                foreach (char item in year)
                {
                    if (item > '9')
                    {
                        checkEntry = false;
                    }
                }
                var checkYear = 0;
                if (checkEntry)
                {
                    checkYear = Convert.ToInt32(year);
                }
                else
                {
                    Console.WriteLine("Invalid Entry!");
                    Main();
                }
                Console.WriteLine(DateTime.IsLeapYear(checkYear) ? "Yes, the year is leap!" : "Is not a leap year!");
            }
        }
    }
}