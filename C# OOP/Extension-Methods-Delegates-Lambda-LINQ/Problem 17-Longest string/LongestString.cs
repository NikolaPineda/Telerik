using System;
using System.Linq;

namespace Longest_string
{
    public class LongestString
    {
        private static int maxLength = 0;

        private static void Main()
        {
            var arrayOfStrings = new string[5] {"Gosho", "Zoro", "Kremena", "Kaspichanski", "Typcho"};
            var maxLengthString = arrayOfStrings.OrderByDescending(x => x.Length).First();
            Console.WriteLine("The longest element is:{0}", maxLengthString);
        }
    }
}