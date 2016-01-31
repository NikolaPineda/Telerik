using System;
using System.Globalization;

namespace Problem_17_Date_in_Bulgarian
{
    //Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
    internal class DateInBulgarian
    {
        private static void Main()
        {
            Console.WriteLine("Enter data and time in format <day, month, year, hours, minutes, second>");
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                var inputData = readLine
                    .Split(new[] {',', ' ', ':', '.', '/'}, StringSplitOptions.RemoveEmptyEntries);
                var days = Convert.ToInt32(inputData[0]);
                var months = Convert.ToInt32(inputData[1]);
                var years = Convert.ToInt32(inputData[2]);
                var hours = Convert.ToInt32(inputData[3]);
                var minutes = Convert.ToInt32(inputData[4]);
                var seconds = Convert.ToInt32(inputData[5]);
                var date = new DateTime(years, months, days, hours, minutes, seconds);
                var culture = new CultureInfo("bg-BG");
                var dayOfWeek = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
                Console.WriteLine(new string('-', 15));
                Console.WriteLine("Time now: {0}", date);
                Console.WriteLine(dayOfWeek);
                Console.WriteLine(new string('-', 15));

                date = date.AddHours(6).AddMinutes(30);
                dayOfWeek = culture.DateTimeFormat.GetDayName(date.DayOfWeek);

                Console.WriteLine("Time after 6 hours and 30 minutes: {0}", date);
                Console.WriteLine(dayOfWeek);
            }
            Console.WriteLine(new string('-', 15));
        }
    }
}