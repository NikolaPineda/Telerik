using System;
using System.Globalization;
using System.Threading;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

namespace Problem_19_Dates_from_text_in_Canada
{
    internal class DateFromText
    {
        private static void Main()
        {
            Console.WriteLine("Enter text:");
            var text = Console.ReadLine();
            if (text != null)
            {
                var textWords = text.Split(' ');
                foreach (string item in textWords)
                {
                    try
                    {
                        var date = DateTime.ParseExact(item.TrimEnd(',', '.', '!', '?'), "d.M.yyyy",
                            CultureInfo.InvariantCulture);
                        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                        Console.WriteLine("Canada (english): {0}", date.Date.ToLongDateString());
                    }
                    catch (FormatException)
                    {
                    }
                }
            }
        }
    }
}