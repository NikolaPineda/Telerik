using System;

namespace First_before_last
{
    public class Student
    {
        private uint age;
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public uint Age
        {
            get { return age; }
            set
            {
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("Your student is too old! Can't be Yoda!");
                }
                age = value;
            }
        }
    }
}