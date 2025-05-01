//Written by Swornashabi
// 2/2/2025
namespace ReparingTheClockTower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //taking input
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            //finding if the number is odd or even
            if(number % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}
