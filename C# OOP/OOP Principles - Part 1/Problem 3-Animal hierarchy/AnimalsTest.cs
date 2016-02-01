using System;

namespace Animals
{
    internal class AnimalsTest
    {
        /*
        Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
        Dogs, frogs and cats are Animals.
        All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. 
        All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male.
        Each animal produces a specific sound.
        Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
        */
        private static void Main()
        {
            Animal[] animals =
            {
                new Tomcat("Tom", 5), new Frog("Toad", 3, Sex.Male), new Kitten("Mimi", 4),
                new Dog("Lassie", 10, Sex.Female), new Cat("Emy", 2, Sex.Female),
                new Dog("Sharo", 20, Sex.Male)
            };

            Dog[] doggies =
            {
                new Dog("Lassie", 10, Sex.Female), new Dog("Sharo", 15, Sex.Male),
                new Dog("Murdjo", 40, Sex.Male), new Dog("Bethoven", 20, Sex.Male),
                new Dog("Kiki", 2, Sex.Male)
            };
            Console.WriteLine("The average age of animals is {0:0.00}", Animal.GetAverage(animals));
            Console.WriteLine("The average age of doggies is {0}", Animal.GetAverage(doggies));

            foreach (var animal in animals)
            {
                Console.WriteLine("{0} And I say {1}", animal, animal.MakeSound());
            }
        }
    }
}