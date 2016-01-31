using System;

namespace Problem_3_Variable_in_Hexadecimal_Format
{
    internal class Program
    {
        private static void Main()
        {
            var decValue = 254;
            var hexValue = decValue.ToString("X");
            Console.WriteLine(hexValue);
        }
    }
}