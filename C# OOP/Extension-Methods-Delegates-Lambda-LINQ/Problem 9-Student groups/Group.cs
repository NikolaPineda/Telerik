using System;

namespace Student_groups
{
    public class Group
    {
        private byte groupNumber;

        public Group(byte number, DepartmenEnum input)
        {
            DeparmetnNamex = input.ToString();
            GroupNumber = number;
        }

        public byte GroupNumber
        {
            get { return groupNumber; }
            set
            {
                if (value < 1 || value > 2)
                {
                    throw new ArgumentOutOfRangeException("The groups must be 1 or 2!");
                }
                groupNumber = value;
            }
        }

        public string DeparmetnNamex { get; set; }
    }
}