using System;

namespace Person
{
    internal class PersonTest
    {
        /*
        Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.*/

        private static void Main()
        {
            var somePerson = new Person("Gosho");
            var otherPerson = new Person("Pesho", 10);
            Console.WriteLine(somePerson);
            Console.WriteLine(otherPerson);
        }
    }
}