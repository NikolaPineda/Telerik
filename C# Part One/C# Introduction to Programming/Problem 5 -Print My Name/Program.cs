using System;

namespace Problem_5__Print_My_Name
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter your first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Your name is: {0} {1}", firstName, lastName);
        }
    }
}