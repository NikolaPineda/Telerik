using System;

namespace Problem_10_Employee_Data
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine();
            var firstName = "Nikola";
            var lastName = "Pineda";
            byte age = 25;
            var gender = 'm';
            ulong PersonalIDNumber = 8306112507;
            uint UniqueEmployeeNumber = 27569999;
            Console.WriteLine("Enter first name:{0}", firstName);
            Console.WriteLine("Enter last name:{0}", lastName);
            Console.WriteLine("Enter your age:{0}", age);
            Console.WriteLine("Enter genter:{0}", gender);
            Console.WriteLine("Enter personal ID number:{0}", PersonalIDNumber);
            Console.WriteLine("Enter unique employee number:{0}", UniqueEmployeeNumber);
        }
    }
}