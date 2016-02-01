namespace ShcoolClasses
{
    public class Discipline : ICommentable
    {
        public Discipline(DisciplinesNames input, byte lectures, uint exercises)
        {
            Name = input;
            NumberOfLectures = lectures;
            NumberOfExercises = exercises;
        }

        public byte NumberOfLectures { get; set; }
        public uint NumberOfExercises { get; set; }
        public DisciplinesNames Name { get; set; }

        public string Comments { get; set; }

        public override string ToString()
        {
            return string.Format("Discipline name is: {0}, number of lectures is; {1} and number of exercise is: {2}",
                Name, NumberOfLectures, NumberOfExercises);
        }
    }
}