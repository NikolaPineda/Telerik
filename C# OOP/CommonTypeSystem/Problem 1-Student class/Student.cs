using System;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace StudentClass
{
    public class Student : ICloneable, IComparable<Student>
    {
        private readonly byte course;
        private string email;
        private string firstName;
        private string lastName;
        private string midleName;
        private string mobilePhone;

        public Student(string firstN, string midleN, string lastN, uint ssNumber, string adressX, string phone,
            string mail, byte curentCourse, Specialty spec, University uni, Faculties faculty)
        {
            firstName = firstN;
            midleName = midleN;
            lastName = lastN;
            SSN = ssNumber;
            Adress = adressX;
            mobilePhone = phone;
            email = mail;
            course = curentCourse;
            Specialty = spec;
            University = uni;
            Faculty = faculty;
        }

        public string FirstName
        {
            get { return firstName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not null or empty!");
                }
                firstName = value;
            }
        }

        public string MidleName
        {
            get { return midleName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not null or empty!");
                }
                midleName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not null or empty!");
                }
                lastName = value;
            }
        }

        public uint SSN { get; protected set; }
        public string Adress { get; protected set; }

        public string MobilePhone
        {
            get { return mobilePhone; }
            protected set
            {
                if (value[0] != '0' || value[0] != '+')
                {
                    throw new ArgumentException("You must enter correct number!");
                }
                for (var i = 1; i < value.Length; i++)
                {
                    if (value[i] > 9)
                    {
                        throw new ArgumentException("You must enter correct number!");
                    }
                }
                if (value[0] == '0' && value.Length != 10 || value[0] == '+' && value.Length != 13)
                {
                    throw new ArgumentException("You must enter correct  mobile number!");
                }
                mobilePhone = value;
            }
        }

        public string Email
        {
            get { return email; }
            protected set
            {
                var addr = new MailAddress(value);
                email = value;
            }
        }

        public byte Course
        {
            get { return course; }
            protected set
            {
                if (value > 6)
                {
                    throw new ArgumentException("You must enter a valid course!");
                }
            }
        }

        public Specialty Specialty { get; protected set; }
        public University University { get; protected set; }
        public Faculties Faculty { get; protected set; }

        public object Clone()
        {
            return new Student
                (
                firstName,
                midleName,
                lastName,
                SSN,
                Adress,
                mobilePhone,
                email,
                course,
                Specialty,
                University,
                Faculty
                );
        }

        public int CompareTo(Student oderStudent)
        {
            if (string.Compare(FirstName, oderStudent.FirstName, StringComparison.Ordinal) != 0)
            {
                return string.Compare(FirstName, oderStudent.FirstName, StringComparison.Ordinal);
            }
            return string.Compare(SSN.ToString(), oderStudent.SSN.ToString(), StringComparison.Ordinal);
        }

        public override bool Equals(object obj)
        {
            var thisStudent = GetType().GetProperties();
            var inputStudent = obj.GetType().GetProperties();
            if (!(obj is Student) || thisStudent.Length == inputStudent.Length)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            // Get the hashcodes of each and every property value and mash them together
            var properties = GetType().GetProperties();

            return properties.Aggregate(12412, (current, property) => current ^ property.GetValue(this).GetHashCode());
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            var properties = GetType().GetProperties();
            foreach (var item in properties)
            {
                output.Append(item.Name);
                output.Append(": ");
                output.Append(item.GetValue(this));
                output.Append(Environment.NewLine);
            }
            return output.ToString().TrimEnd();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent == secondStudent);
        }
    }
}