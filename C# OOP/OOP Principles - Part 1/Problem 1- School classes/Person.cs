using System;

namespace ShcoolClasses
{
    public abstract class Person
    {
        private string name;

        protected Person(string inputName)
        {
            name = inputName;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be null or empty!");
                }
                name = value;
            }
        }
    }
}