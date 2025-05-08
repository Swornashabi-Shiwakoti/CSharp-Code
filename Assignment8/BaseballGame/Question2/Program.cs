//Written by Swornashabi
namespace Question2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BaseballGame game = new BaseballGame();

            string[] ops1 = { "5", "2", "C", "D", "+" };
            string[] ops2 = { "5", "-2", "4", "C", "D", "9", "+", "+" };

            Console.WriteLine(game.CalPoints(ops1));
            Console.WriteLine(game.CalPoints(ops2));
        }
    }
}
