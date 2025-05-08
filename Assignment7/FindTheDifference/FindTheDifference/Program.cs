namespace FindTheDifference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindExtraCharacter finder = new FindExtraCharacter();

            Console.WriteLine(finder.FindTheDifference("abcd", "abcde"));
        }
    }
}
