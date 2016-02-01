using System.Collections.Generic;

namespace ShcoolClasses
{
    public class Teacher : Person, ICommentable
    {
        private readonly List<Discipline> listOfDisciplines = new List<Discipline>();

        public Teacher(string inputName)
            : base(inputName)
        {
        }

        public string Comments { get; set; }
    }
}