using System;

namespace Person
{
    internal class Person
    {
        private int? age;
        private string name;

        public Person(string inputName, int? ageInput = null)
        {
            name = inputName;
            Age = ageInput;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null or empty!");
                }
                name = value;
            }
        }

        public int? Age
        {
            get { return age; }
            set
            {
                if (value > 160)
                {
                    throw new ArgumentOutOfRangeException("Age must be smaller by 160!");
                }
                age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("My name is {0} and my age is {1}", Name,
                string.IsNullOrEmpty(Age.ToString()) ? "unspecified" : Age.ToString());
        }
    }
}