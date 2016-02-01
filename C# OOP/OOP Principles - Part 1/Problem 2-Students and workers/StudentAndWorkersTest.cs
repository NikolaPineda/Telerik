using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    public class StudentAndWorkersTest
    {
        /*
        Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade.
        Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker.
        Define the proper constructors and properties for this hierarchy.
        Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
        Initialize a list of 10 workers and sort them by money per hour in descending order.
        Merge the lists and sort them by first name and last name.
        */
        internal static void Main()
        {
            // Create list of students
            var listOfStudents = new List<Student>
            {
                new Student("Pesho", "Peshov", 11),
                new Student("Gergi", "Savov", 12),
                new Student("Samat", "Petrov", 10),
                new Student("Gospodin", "Filipov", 9),
                new Student("Miro", "Duplev", 8),
                new Student("Mitka", "Zenginov", 7),
                new Student("Evlogi", "Pchelarov", 12),
                new Student("Stefan", "KRystev", 13),
                new Student("Zoro", "Georgiev", 11),
                new Student("Kamen", "Kamenov", 12)
            };
            // List of student by ascending grade
            var listByAscendingGrade = listOfStudents.OrderBy(s => s.Grade);
            foreach (var student in listByAscendingGrade)
            {
                Console.WriteLine(student);
            }
            // Create list of workers
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////");
            var listOfWorkers = new List<Worker>
            {
                new Worker("Georgi", "Bonev", 200, 12),
                new Worker("Stevan", "Savov", 300, 11),
                new Worker("Tachko", "Tashev", 100, 5),
                new Worker("Stoiko", "Stoichkov", 250, 13),
                new Worker("Stanimir", "Shmatkov", 400, 8),
                new Worker("Ivan", "Ivanov", 200, 4),
                new Worker("Stoqn", "Canev", 600, 7),
                new Worker("Iraklii", "Zdravkov", 150, 6),
                new Worker("Zdravko", "Georgiev", 300, 7),
                new Worker("Katelina", "Penevska", 500, 7),
                new Worker("Jordan", "Draganov", 400, 6)
            };
            var listOfMonny = listOfWorkers.OrderByDescending(worker => worker.MoneyPerHower());
            foreach (var worker in listOfMonny)
            {
                Console.WriteLine(worker);
            }
            // Merge the two lists
            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////");
            var concatList = new List<IWorkerAndStudetn>();
            foreach (var item in listOfStudents)
            {
                concatList.Add(item);
            }
            foreach (var item in listOfWorkers)
            {
                concatList.Add(item);
            }
            var newConcatList = concatList.OrderBy(person => person.FirstName).ThenBy(person => person.LastName);
            foreach (var item in newConcatList)
            {
                Console.WriteLine(item);
            }
        }
    }
}