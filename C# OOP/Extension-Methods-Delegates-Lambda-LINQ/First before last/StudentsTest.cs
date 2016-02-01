using System;
using System.Collections.Generic;
using System.Linq;

namespace First_before_last
{
    public class StudentsTest
    {
        internal static void Main()
        {
            var listOfStudents = new List<Student>
            {
                new Student {FirstName = "Gosho", SecondName = "Georgiev", Age = 15},
                new Student {FirstName = "Goran", SecondName = "Goranov", Age = 30},
                new Student {FirstName = "Karamfil", SecondName = "Typchov", Age = 44},
                new Student {FirstName = "Kamenski", SecondName = "Mangov", Age = 22},
                new Student {FirstName = "Shasho", SecondName = "Simeonov", Age = 24}
            };
            var alpfabetLastName =
                from student in listOfStudents
                where string.Compare(student.FirstName, student.SecondName, StringComparison.Ordinal) < 0
                select student;

            // Print Last Names test
            Console.WriteLine("Name task !!!");
            foreach (var student in alpfabetLastName)
            {
                Console.WriteLine(student.FirstName);
            }

            //  Print names by age test
            var ageOfStudentTaks =
                from student in listOfStudents
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine();
            Console.WriteLine("Age task !!!");
            foreach (var student in ageOfStudentTaks)
            {
                Console.WriteLine(student.FirstName + " " + student.SecondName);
            }

            // OrderBy and ThenBy
            Console.WriteLine();
            Console.WriteLine("OrderBy and ThenBy task !!!");
            foreach (
                var student in listOfStudents.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.SecondName))
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.SecondName);
            }

            Console.WriteLine();
            Console.WriteLine("Linq task !!!");

            var descendingListOfStudents = from student in listOfStudents
                orderby student.FirstName descending, student.SecondName descending
                select student;
            foreach (var strudent in descendingListOfStudents)
            {
                Console.WriteLine("{0} {1}", strudent.FirstName, strudent.SecondName);
            }
        }
    }
}