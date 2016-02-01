namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, byte age, Sex sexInput) : base(name, age, sexInput)
        {
        }

        public override string MakeSound()
        {
            return "Bau!";
        }
    }
}