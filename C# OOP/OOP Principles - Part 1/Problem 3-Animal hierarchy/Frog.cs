namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string name, byte age, Sex sexInput) : base(name, age, sexInput)
        {
        }

        public override string MakeSound()
        {
            return "Kvak!";
        }
    }
}