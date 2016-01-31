using System;

namespace Problem_2_Bonus_Score
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that applies bonus score to given score in the range [1…9] by the following rules:
                If the score is between 1 and 3, the program multiplies it by 10.
                If the score is between 4 and 6, the program multiplies it by 100.
                If the score is between 7 and 9, the program multiplies it by 1000.
                If the score is 0 or more than 9, the program prints “invalid score”.*/

            int score;
            Console.WriteLine("Enter score:");
            var isScore = int.TryParse(Console.ReadLine(), out score);
            if (isScore)
            {
                if (score > 0 && score < 4)
                {
                    score = score*10;
                    Console.WriteLine("Score is:{0}", score);
                }
                else if (score > 3 && score < 7)
                {
                    score = score*100;
                    Console.WriteLine("Score is:{0}", score);
                }
                else if (score > 6 && score < 9)
                {
                    score = score*1000;
                    Console.WriteLine("Score is:{0}", score);
                }
                else
                {
                    Console.WriteLine("Invalid score!");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
        }
    }
}