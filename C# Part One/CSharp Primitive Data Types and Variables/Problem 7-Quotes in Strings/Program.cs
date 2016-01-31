using System;

namespace Problem_7_Quotes_in_Strings
{
    internal class Program
    {
        private static void Main()
        {
            var variantA = "The \"use\" of quotations causes difficulties.";
            var variantB = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(variantA);
            Console.WriteLine(variantB);
        }
    }
}