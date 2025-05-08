// Written by Swornashabi
namespace Question4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RecentCounter recentCounter = new RecentCounter();

            Console.WriteLine(recentCounter.Ping(1));
            Console.WriteLine(recentCounter.Ping(100));
            Console.WriteLine(recentCounter.Ping(3001));
        }
    }
}
