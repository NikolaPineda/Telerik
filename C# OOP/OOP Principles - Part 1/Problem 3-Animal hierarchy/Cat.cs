namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, byte age, Sex sexInput) : base(name, age, sexInput)
        {
        }

        public override string MakeSound()
        {
            return "Miau!";
        }
    }
}