using System;

namespace Attributes
{
    [AttributeVersion("3.8")]
    internal class Attributes
    {
        private static void Main()
        {
            var versionAttributes = typeof (Attributes).GetCustomAttributes(typeof (AttributeVersion), false);

            Console.WriteLine("Current version: {0}", versionAttributes[0]);
        }
    }
}