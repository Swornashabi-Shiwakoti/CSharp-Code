// Written by Swornashabi

namespace BracketValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BracketValidator validator = new BracketValidator();

            Console.WriteLine(validator.IsValid("()"));
            Console.WriteLine(validator.IsValid("()[]{}"));
            Console.WriteLine(validator.IsValid("(]"));
        }
    }
}
