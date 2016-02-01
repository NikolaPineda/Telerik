namespace ShcoolClasses
{
    public class Student : Person, ICommentable
    {
        public Student(string name, uint classNumber)
            : base(name)
        {
            UnicClassNumber = classNumber;
        }

        public uint UnicClassNumber { get; }

        public string Comments { get; set; }

        public override string ToString()
        {
            return string.Format("I am  {0}, with personal number {1}", Name, UnicClassNumber);
        }
    }
}