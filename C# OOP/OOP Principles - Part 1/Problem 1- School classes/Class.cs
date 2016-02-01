using System.Collections.Generic;

namespace ShcoolClasses
{
    public class Class : ICommentable
    {
        private readonly List<Student> students = new List<Student>();
        private readonly List<Teacher> teachers = new List<Teacher>();

        public Class(string nameInput)
        {
            Name = nameInput;
        }

        public string Name { get; set; }

        public string Comments { get; set; }
    }
}