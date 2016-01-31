﻿using System;

namespace Problem_10_Beer_Time
{
    internal class Program
    {
        private static void Main()
        {
            /*A beer time is after 1:00 PM and before 3:00 AM.
            Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
            a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
            Note: You may need to learn how to parse dates and times.*/

            Console.WriteLine("Enter time: HH:mm tt");
            DateTime time;
            var time1 = "1:00 PM";
            var time2 = "3:00 AM";
            var start = DateTime.Parse(time1);
            var stop = DateTime.Parse(time2);
            var isData = DateTime.TryParse(Console.ReadLine(), out time);
            if (isData)
            {
                if (time > start && time < stop)
                {
                    Console.WriteLine("Is beer time!");
                }
                else
                {
                    Console.WriteLine("Not beer time!");
                }
            }
            else
            {
                Console.WriteLine("Invalid time!");
            }
            //Handy data!!!
            //string format = "HH:mm tt";
            //Console.WriteLine(time.ToString(format));           
            //Console.WriteLine(DateTime.Compare(DateTime.Now, data));
        }
    }
}