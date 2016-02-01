using System;
using System.Collections.Generic;
using System.Linq;

namespace Grouped_by_GroupNumber
{
    internal class GroupNumberTest
    {
        private static void Main()
        {
            var listOfStudents = new List<Student>
            {
                new Student(3, "Goshso"),
                new Student(4, "Sasho"),
                new Student(3, "Stamat"),
                new Student(4, "Zdravko"),
                new Student(3, "Loshso"),
                new Student(4, "Pana"),
                new Student(3, "Pesho"),
                new Student(4, "Ezikiel"),
                new Student(3, "Temerut"),
                new Student(4, "Asem")
            };
            // using Linq
            var studentList = from student in listOfStudents
                orderby student.GroupNumber
                select student;
            foreach (var item in studentList)
            {
                Console.WriteLine("Name: {0}, group number:{1}", item.GroupName, item.GroupNumber);
            }
            //using extensions
            Console.WriteLine();
            var studentListExt = listOfStudents.OrderBy(s => s.GroupNumber);
            foreach (var item in studentListExt)
            {
                Console.WriteLine("Name: {0}, group number:{1}", item.GroupName, item.GroupNumber);
            }
        }
    }
}