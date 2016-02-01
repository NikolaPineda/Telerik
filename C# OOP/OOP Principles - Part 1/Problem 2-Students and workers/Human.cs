using System;

namespace StudentsAndWorkers
{
    public abstract class Human : IWorkerAndStudetn
    {
        private string firstName;
        private string lastName;

        protected Human(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name can't be null or empty!");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name can't be null or empty!");
                }
                lastName = value;
            }
        }
    }
}