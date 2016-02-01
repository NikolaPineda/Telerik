namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, byte age) : base(name, age, Sex.Male)
        {
        }

        public string DaMuMiakata()
        {
            var kostana = "mainata ti";
            return kostana;
        }
    }
}