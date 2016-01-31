using System;

namespace Problem_Print_Company_Information
{
    internal class Program
    {
        private static void Main()
        {
            /*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

            Console.WriteLine("Enter company name:");
            var companyName = Console.ReadLine();
            Console.WriteLine("Enter company address:");
            var companyAddress = Console.ReadLine();
            Console.WriteLine("Enter phone number:");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter fax number:");
            var faxNumber = Console.ReadLine();
            Console.WriteLine("Enter web site:");
            var webSite = Console.ReadLine();
            Console.WriteLine("Enter first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            var age = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            var managerPhone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Company name:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), companyName);
            Console.WriteLine("Company address:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), companyAddress);
            Console.WriteLine("Phone number:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), phoneNumber);
            Console.WriteLine("Fax number:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), faxNumber);
            Console.WriteLine("Website:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), webSite);
            Console.WriteLine("First name:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), firstName);
            Console.WriteLine("Last name:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), lastName);
            Console.WriteLine("Age:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), age);
            Console.WriteLine("Address:".PadRight(20 + ' ') + "{0, 10}".PadLeft(30 + ' '), managerPhone);
        }
    }
}