using System;

//Write a program to check if in a given expression the brackets are put correctly.

namespace Problem_3_Correct_brackets
{
    internal class CorrectBrackets
    {
        private static readonly char[] Operators = {'+', '-', '/', '*'};

        private static void Main()
        {
            Console.WriteLine("Enter expresion with brackets:");
            var input = Console.ReadLine();
            if (CheckInput(input))
            {
                var check = true;
                for (var i = 1; i < input.Length - 1; i++)
                {
                    foreach (char item in Operators)
                    {
                        if (input[i] == '(' && input[i + 1] == item)
                        {
                            check = false;
                        }
                        if (input[i] == ')' && input[i - 1] == item)
                        {
                            check = false;
                        }
                    }
                }
                Console.WriteLine(check
                    ? "The brackets in your expression are put correctly."
                    : "The brackets in your expression are put incorrectly.");
            }
            else
            {
                Console.WriteLine("Incorect input! You are missing brackets!");
            }
        }

        private static bool CheckInput(string input)
        {
            var check = true;
            var openBracketCount = 0;
            var closeBracketCount = 0;
            foreach (char item in input)
            {
                if (item == '(')
                {
                    openBracketCount++;
                }
                else if (item == ')')
                {
                    closeBracketCount++;
                }
                if (closeBracketCount == 1 && openBracketCount == 0)
                {
                    check = false;
                }
            }
            if (openBracketCount - closeBracketCount != 0)
            {
                check = false;
            }
            return check;
        }
    }
}