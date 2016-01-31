using System;
using System.Text;

namespace Problem_7_Encode_decode
{
    //Write a program that encodes and decodes a string using given encryption key (cipher).
    //The key consists of a sequence of characters.
    //The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
    internal class EncodeDecode
    {
        private static void Main()
        {
            Console.WriteLine("Enter text:");
            var input = Console.ReadLine();
            Console.WriteLine("Enter cipher");
            var cipher = Console.ReadLine();
            Console.WriteLine("Encodet - {0}", Encoded(input, cipher));
            Console.WriteLine("Decodet - {0}", Encoded(Encoded(input, cipher), cipher));
        }

        private static string Encoded(string input, string cipher)
        {
            var result = new StringBuilder();
            for (var i = 0; i < input.Length; i++)
            {
                int inputChar = input[i];
                int cipherChar = cipher[i%cipher.Length];
                result.Append((char) (inputChar ^ cipherChar));
            }
            return result.ToString();
        }
    }
}