using System;

namespace Problem_6_Strings_and_Objects
{
    internal class Program
    {
        private static void Main()
        {
            var hallo = "Hallo";
            var world = "World";
            object concatenation = hallo + " " + world;
            var mixAll = Convert.ToString(concatenation);
            Console.WriteLine(mixAll);
        }
    }
}