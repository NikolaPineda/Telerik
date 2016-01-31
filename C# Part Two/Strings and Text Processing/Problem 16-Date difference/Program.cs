using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
namespace Problem_16_Date_difference
{
    class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("Enter first data in format<dd.mm.yyyy>:");
            string[] firstData = new string[3];
            string[] secondData = new string[3];
            firstData = Console.ReadLine().Split('.');
            Console.WriteLine("Enter second data in format<dd.mm.yyyy>:");
            secondData = Console.ReadLine().Split('.');
            DateTime first = new DateTime(Convert.ToInt32(firstData[2]), Convert.ToInt32(firstData[1]), Convert.ToInt32(firstData[0]));
            DateTime second = new DateTime(Convert.ToInt32(secondData[2]), Convert.ToInt32(secondData[1]), Convert.ToInt32(secondData[0]));
            int days = 0;
            if (first > second)
            {
                Console.WriteLine((first - second).TotalDays);
            }
            else
            {
                Console.WriteLine((second - first).TotalDays);
            }
        }
    }
}
