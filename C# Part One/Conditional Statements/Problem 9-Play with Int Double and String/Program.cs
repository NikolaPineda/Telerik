using System;

namespace Problem_9_Play_with_Int_Double_and_String
{
    internal class Program
    {
        private static void Main()
        {
            /*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            If the variable is int or double, the program increases it by one.
            If the variable is a string, the program appends * at the end.
            Print the result at the console. Use switch statement.*/

            Console.WriteLine("Please choose a tipe (strng , int or double)");
            int chois;
            var isChois = int.TryParse(Console.ReadLine(), out chois);
            if (isChois && chois > 0 && chois < 4)
            {
                switch (chois)
                {
                    case 1:
                        Console.WriteLine("Enter integer:");
                        var chois1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result = {0}", chois1 + 1);
                        break;
                    case 2:
                        Console.WriteLine("Enter double:");
                        var chois2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Result = {0}", chois2 + 1);
                        break;
                    case 3:
                        Console.WriteLine("Enter string:");
                        var chois3 = Console.ReadLine();
                        Console.WriteLine(chois3 + "*");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid chois!");
            }
        }
    }
}