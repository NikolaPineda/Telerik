using System;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private byte grade;

        public Student(string first, string last, byte gradeInput) : base(first, last)
        {
            grade = gradeInput;
        }

        public byte Grade
        {
            get { return grade; }
            set
            {
                if (value > 13)
                {
                    throw new ArgumentOutOfRangeException("Bulgaria have only 13 grades!");
                }
                grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name:{0}, second name: {1}, grade: {2}", FirstName, LastName, Grade);
        }
    }
}