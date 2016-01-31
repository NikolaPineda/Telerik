using System;

namespace Problem_1_Say_Hallo
{
    internal class Program
    {
        private static void Hallo()
        {
            Console.WriteLine("Enter your first name:");
            var name = Console.ReadLine();
            Console.WriteLine("Hallo {0}!", name);
        }

        private static void Main()
        {
            /*
            Write a method that asks the user for his name and prints “Hello, <name>”
            Write a program to test this method.
            */

            Hallo();
        }
    }
}