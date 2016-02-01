using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private readonly string sex;

        protected Animal(string nameInput, byte ageInput, Sex inputSex)
        {
            name = nameInput;
            Age = ageInput;
            sex = inputSex.ToString();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }
                name = value;
            }
        }

        public byte Age { get; set; }


        public abstract string MakeSound();

        public static double GetAverage(IEnumerable<Animal> animals)
        {
            return animals.Average(a => a.Age);
        }

        public override string ToString()
        {
            return string.Format("My name is {0}, i'm {1} years old, I'm {2} and I'm {3}", name, Age, sex,
                GetType().Name);
        }
    }
}