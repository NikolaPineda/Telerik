using System;

namespace Problem_15_Age_after_10
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter your year of birth");
            var yearOfBith = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a month:");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a day of birth:");
            var dayOfBirth = int.Parse(Console.ReadLine());

            var myBirthDay = new DateTime(yearOfBith, month, dayOfBirth);
            var dayTimeNow = DateTime.Now;
            var age = dayTimeNow.Year - myBirthDay.Year;
            if (dayTimeNow.Month < myBirthDay.Month)
            {
                age = age - 1;
            }
            else if (myBirthDay.Month == dayTimeNow.Month)
            {
                if (dayTimeNow.Day < myBirthDay.Day)
                {
                    age = age - 1;
                }
            }
            Console.WriteLine("Your age is :{0}", age);
            Console.WriteLine("After ten year your age will be:{0}", age + 10);
        }
    }
}