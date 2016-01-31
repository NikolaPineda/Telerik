using System;

namespace Problem_4_Print_a_Deck_of_52_Cards
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
            The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
            The card faces should start from 2 to A.
            Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
            Use 2 nested for-loops and a switch-case statement.*/

            for (var i = 0; i <= 4; i++)
            {
                for (var j = 0; j < 13; j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write("Ace");
                            break;
                        case 1:
                            Console.Write("Two");
                            break;
                        case 2:
                            Console.Write("Three");
                            break;
                        case 3:
                            Console.Write("four");
                            break;
                        case 4:
                            Console.Write("Five");
                            break;
                        case 5:
                            Console.Write("Six");
                            break;
                        case 6:
                            Console.Write("Seven");
                            break;
                        case 7:
                            Console.Write("Eight");
                            break;
                        case 8:
                            Console.Write("Nine");
                            break;
                        case 9:
                            Console.Write("Ten");
                            break;
                        case 10:
                            Console.Write("Jack");
                            break;
                        case 11:
                            Console.Write("Qween");
                            break;
                        case 12:
                            Console.Write("King");
                            break;
                    }
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine(" of clubs ");
                            break;
                        case 1:
                            Console.WriteLine(" of diamonts ");
                            break;
                        case 2:
                            Console.WriteLine(" of Hearts ");
                            break;
                        case 3:
                            Console.WriteLine(" of Spades ");
                            break;
                    }
                }
            }
        }
    }
}