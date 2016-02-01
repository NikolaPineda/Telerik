using System;
using System.Text;

namespace HomeworkProgram
{
    internal class HomeworkProgram
    {
        private static void Main()
        {
            var sb = new StringBuilder();
            sb.Append("Gosho");
            sb.Append("Tosho");
            sb.Append("Tybakov");
            Console.WriteLine(sb.BilderEx(0, 10));
        }
    }
}