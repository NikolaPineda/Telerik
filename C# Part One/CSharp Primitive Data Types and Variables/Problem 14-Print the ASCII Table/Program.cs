using System;

namespace Problem_14_Print_the_ASCII_Table
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Decimal".PadRight(10));
            Console.Write("ASCII".PadRight(10));
            Console.Write("Hex".PadRight(10));
            Console.WriteLine();

            var min = 0;
            var max = 255;
            for (var i = min; i < max; i++)
            {
                var c = (char) i;

                string display;
                if (char.IsWhiteSpace(c))
                {
                    display = c.ToString();
                    switch (c)
                    {
                        case '\t':
                            display = "\\t";
                            break;
                        case ' ':
                            display = "space";
                            break;
                        case '\n':
                            display = "\\n";
                            break;
                        case '\r':
                            display = "\\r";
                            break;
                        case '\v':
                            display = "\\v";
                            break;
                        case '\f':
                            display = "\\f";
                            break;
                    }
                }
                else if (char.IsControl(c))
                {
                    display = "control";
                }
                else
                {
                    display = c.ToString();
                }
                Console.Write(i.ToString().PadRight(10));
                Console.Write(display.PadRight(10));
                Console.Write(i.ToString("X2"));
                Console.WriteLine();
            }
        }
    }
}