using System;
using System.Collections.Generic;

namespace Student_groups
{
    public class Student
    {
        private byte groupeNumber;
        private List<byte> marks;
        private readonly string tel;

        public Student(string firstN, string lastN, long fn, string phone, string mail, List<byte> marksX, byte group)
        {
            FirstName = firstN;
            LastName = lastN;
            FN = fn;
            tel = phone;
            Email = mail;
            marks = marksX;
            groupeNumber = group;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public long FN { get; set; }

        public string Tel
        {
            get { return tel; }
            set
            {
                for (var i = 0; i < value.Length; i++)
                {
                    if (value[0] > '9' || value[i] != '+')
                    {
                        throw new ArgumentOutOfRangeException("First digit of the number must be digit or + !");
                    }
                    if (value[i] > '9')
                    {
                        throw new ArgumentOutOfRangeException("Phone number must be secuence of digits!");
                    }
                }
            }
        }

        public string Email { get; set; }

        public List<byte> Marks
        {
            get { return marks; }
            set
            {
                marks = value;
                foreach (var item in marks)
                {
                    if (item > 6 || item < 2)
                    {
                        throw new ArgumentOutOfRangeException("Marks must be from 2 to 6!");
                    }
                }
            }
        }

        public byte GroupeNumber
        {
            get { return groupeNumber; }
            set
            {
                groupeNumber = value;
                if (groupeNumber < 1 || groupeNumber > 2)
                {
                    throw new ArgumentOutOfRangeException("There are only two groups");
                }
            }
        }
    }
}