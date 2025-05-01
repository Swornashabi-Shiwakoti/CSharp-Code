// Written by Swornashabi
// 1/30/2025
namespace TheFourSistersAndTheDuckBear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Taking input from user
            Console.WriteLine("Hi! How many chocolate eggs did you gather?");
            int numberOfChocolateEggs = int.Parse(Console.ReadLine());

            // calculating how many eggs fo four sisters and the duck bear gets
            int leftOverChocolateEggs = numberOfChocolateEggs % 4;
            int eggsForEachSister = (numberOfChocolateEggs - leftOverChocolateEggs) / 4;

            //printing output
            Console.WriteLine("Each of the four sisters can enjoy " + eggsForEachSister + " chocolate eggs today!" + "\n");
            Console.WriteLine("The duckbear gets " + leftOverChocolateEggs + " chocolate eggs today!");
        }
    }
}
