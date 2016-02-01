using System;

namespace Bank
{
    public class Customer
    {
        private string name;

        public Customer(string inputName)
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
                    throw new ArgumentNullException("The name of the client can not be null or empty!");
                }
                name = value;
            }
        }
    }
}