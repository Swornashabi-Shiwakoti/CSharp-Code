// Written by Swornashabi
// 2/27/2025

namespace AnimalsAndSounds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog aDog = new Dog("Pluto");
            Console.WriteLine(aDog.ToString());

            Cat aCat = new Cat("Ginger");
            Console.WriteLine(aCat.ToString());
        }
    }
}
