using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_groups
{
    public class StudentGroupTest
    {
        internal static void Main()
        {
            var listOfStudents = new List<Student>
            {
                new Student("Gosho", "Petrov", 1231063244, "02999999", "GSarafimov@abv.bg", new List<byte> {3, 4, 5}, 1),
                new Student("Pesho", "Peshovyt", 124324235, "0897066478", "PeshoGamena@abv.bg", new List<byte> {5, 6, 4},
                    1),
                new Student("Maria", "Skumrieva", 45654646, "0888777777", "Mimi_Obshata@gmail.com",
                    new List<byte> {2, 6, 6}, 1),
                new Student("Gergana", "Lozeva", 2376067751, "+3592999999", "geri_86@mail.bg", new List<byte> {3, 3}, 2),
                new Student("Kaloqn", "Radoslavov", 14867867, "0889875463", "kalata@abv.bg", new List<byte> {5, 6, 6}, 2),
                new Student("Strahil", "kabzimalov", 1432432445, "0889876541", "kabzimalov@gmail.com",
                    new List<byte> {2, 4}, 2)
            };
            // Select student in group two
            var groupeTwo = from student in listOfStudents
                where student.GroupeNumber == 2
                select student;
            // Order by first name with Linq
            Console.WriteLine("Use Linq");
            foreach (var student in groupeTwo.OrderBy(s => s.FirstName))
            {
                Console.WriteLine(student.FirstName);
            }
            // Order by first name with extension methods
            Console.WriteLine();
            Console.WriteLine("Use extension methods");
            var groupeTwoExt = listOfStudents.Where(s => s.GroupeNumber == 2).OrderBy(s => s.FirstName);
            foreach (var item in groupeTwoExt)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine();
            Console.WriteLine("Select all student with abv.bg domain");
            // ABV.bg

            var selectAbv = from student in listOfStudents
                where student.Email.Contains("abv.bg")
                select student;
            foreach (var item in selectAbv)
            {
                Console.WriteLine(item.FirstName);
            }
            // Phone select
            Console.WriteLine();
            Console.WriteLine("Select by phone from Sofia");
            var selectByPhone = from student in listOfStudents
                where student.Tel.StartsWith("+3592") || student.Tel.StartsWith("02")
                select student;
            foreach (var item in selectByPhone)
            {
                Console.WriteLine(item.FirstName);
            }
            // Select students with mark = 6
            Console.WriteLine();
            Console.WriteLine("Select students with mark 6");
            var studentsWithMark6 = from student in listOfStudents
                where student.Marks.ToString().Contains("6")
                select student;
            foreach (var item in studentsWithMark6)
            {
                Console.WriteLine(item);
            }
            // Select students with two marks
            Console.WriteLine();
            Console.WriteLine("Extract student with exact two marks");
            var studetntsWithTwoMarks = listOfStudents.Where(s => s.Marks.Count == 2);
            foreach (var item in studetntsWithTwoMarks)
            {
                Console.WriteLine(item.LastName);
            }
            // Extract marks from students enrolled in 2006
            Console.WriteLine();
            Console.WriteLine("Extract marks form students enrolled in 2006");
            var studentsFrom2006 = listOfStudents.Where(x => x.FN.ToString()[4] == '0' && x.FN.ToString()[5] == '6');
            foreach (var student in studentsFrom2006)
            {
                for (var i = 0; i < student.Marks.Count; i++)
                {
                    Console.Write(student.Marks[i] + " ");
                }
                Console.WriteLine();
            }
            // Create Group
            Console.WriteLine();
            Console.WriteLine("Groupe problem 16*");
            var groupList = new List<Group>
            {
                new Group(1, DepartmenEnum.Biology),
                new Group(2, DepartmenEnum.Mathematics)
            };
            var selectMathematics = from students in listOfStudents
                join grp in groupList on students.GroupeNumber equals grp.GroupNumber
                where grp.DeparmetnNamex == DepartmenEnum.Mathematics.ToString()
                select students;
            foreach (var item in selectMathematics)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}