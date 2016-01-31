using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
namespace Problem_12_Parse_URL
{
    class Program
    {
         
        static void Main()
        {
            
            Console.WriteLine("Enter url:");
            string url = Console.ReadLine();
            int index = 0;
            index = url.IndexOf(':');
            Console.WriteLine("Protocol - {0}", url.Substring(0 ,index));
            url = url.Remove(0, index + 3);
            index = url.IndexOf('/');
            Console.WriteLine("Server - {0}", url.Substring(0, index));
            url = url.Remove(0, index);
            Console.WriteLine("Resourse - {0}", url);

        }
    }
}
