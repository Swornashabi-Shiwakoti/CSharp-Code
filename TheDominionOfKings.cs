//Written by Swornashabi
// 1/30/2025
namespace TheDominionOfKings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //taking input from user
            Console.WriteLine("How many provinces do you have?");
            int numOfProvinces = int.Parse(Console.ReadLine());
            Console.WriteLine("How many duchies do you have?");
            int numOfDuchies = int.Parse(Console.ReadLine());
            Console.WriteLine("How many estates do you have?");
            int numOfEstates = int.Parse(Console.ReadLine());

            //calculating total score
            int total = (1 * numOfEstates) + (3 * numOfDuchies) + (6 * numOfProvinces);

            //displaying total points
            Console.WriteLine("Your total points is: " + total);
        }
    }
}
