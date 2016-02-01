using System;

namespace Grouped_by_GroupNumber
{
    public class Student
    {
        private byte groupNumber;

        public Student(byte number, string name)
        {
            GroupName = name;
            groupNumber = number;
        }

        public byte GroupNumber
        {
            get { return groupNumber; }
            set
            {
                if (value > 10)
                {
                    throw new ArgumentOutOfRangeException("Group number must be smaler than ten!");
                }
                groupNumber = value;
            }
        }

        public string GroupName { get; set; }
    }
}