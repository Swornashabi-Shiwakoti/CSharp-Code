//Written by Swornashabi
//2/3/2025
namespace TheReplicatorOfDTo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] original = new int[5];
            for (int item = 0; item < 5; item++)
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                original[item] = number;
            }

            int[] copy = new int[5];

            for (int index = 0; index < 5; index++)
                copy[index] = original[index];

            for (int index = 0; index < 5; index++)
                Console.WriteLine($"{original[index]} and {copy[index]}");
        }
    }
}
