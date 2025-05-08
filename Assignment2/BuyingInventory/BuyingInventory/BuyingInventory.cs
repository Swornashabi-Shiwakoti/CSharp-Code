//Written by Swornashabi
//2/3/2025
namespace BuyingInventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.WriteLine("What number do you want to see price of?");

            int choice = Convert.ToInt32(Console.ReadLine());

            string response;
            response = choice switch
            {
                1 => "Ropes cost 10 gold.",
                2 => "Torches cost 15 gold.",
                3 => "Climbing Equipment cost 25 gold.",
                4 => "Clean Water cost 1 gold.",
                5 => "Machete cost 20 gold.",
                6 => "Canoe cost 200 gold.",
                7 => "Food Supplies cost 1 gold.",
                _ => "Apologies. I do not know that one.",
            };

            Console.WriteLine(response);
        }
    }
}
