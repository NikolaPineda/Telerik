using System;

namespace Problem_3_Check_for_a_Play_Card
{
    internal class Program
    {
        private static void Main()
        {
            /*Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:*/

            var deck = new[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            Console.WriteLine("Enter a card:");
            var counter = 0;
            var card = Console.ReadLine();
            for (var i = 0; i < deck.Length; i++)
            {
                if (deck[i] == card)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter == 1 ? "Yes" : "No");
        }
    }
}