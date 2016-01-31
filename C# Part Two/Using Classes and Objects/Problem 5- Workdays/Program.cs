using System;
using System.Linq;

namespace Problem_5__Workdays
{
    internal class Program
    {
        private static readonly DateTime[] DayOff =
        {
            new DateTime(2015, 1, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
            new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
            new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
            new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
        };

        private static void CountOfDays(DateTime futureData)
        {
            var count = 0;
            var today = DateTime.Today;
            while (today < futureData)
            {
                if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday &&
                    !DayOff.Contains(today))
                {
                    count++;
                }
                today = today.AddDays(1);
            }
            Console.WriteLine(count);
        }

        private static void Main()
        {
            Console.WriteLine("Please enter future data in format: (mm dd yyyy)");
            var futureData = DateTime.Parse(Console.ReadLine());
            CountOfDays(futureData);
        }
    }
}