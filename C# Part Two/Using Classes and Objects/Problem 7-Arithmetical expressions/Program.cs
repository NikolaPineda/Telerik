using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7_Arithmetical_expressions
{
    internal class Program
    {
        /*
        Write a program that calculates the value of given arithmetical expression.
        The expression can contain the following elements only:
        Real numbers, e.g. 5, 18.33, 3.14159, 12.6
        Arithmetic operators: +, -, *, / (standard priorities)
        Mathematical functions: ln(x), sqrt(x), pow(x,y)
        Brackets (for changing the default priorities): (, )
            */

        public static List<char> ArithmeticOperations = new List<char> {'+', '-', '*', '/'};

        public static List<string> SeparateTokens(string input)
        {
            var result = new List<string>();
            var number = new StringBuilder();
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
                {
                    number.Append('-');
                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && input[i] == '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;
                }
                else if (input[i] == ',')
                {
                    result.Add(",");
                }
                else if (input[i] == '(')
                {
                    result.Add("(");
                }
                else if (input[i] == ')')
                {
                    result.Add(")");
                }
                else if (ArithmeticOperations.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add("ln");
                    i++;
                }
                else if (i + 2 < input.Length && input.Substring(1, 3).ToLower() == "pow")
                {
                    result.Add("pow");
                    i += 2;
                }
                else if (i + 3 < input.Length && input.Substring(1, 4).ToLower() == "sqrt")
                {
                    result.Add("sqrt");
                    i += 3;
                }
            }
            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }
            return result;
        }

        private static void Main()
        {
            Console.WriteLine("Enter expresion:");
            var input = Console.ReadLine().Trim();
            var trimInput = input.Replace(" ", string.Empty);
        }
    }
}