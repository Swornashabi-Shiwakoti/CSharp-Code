// Written by Swornashabi
namespace MergeStringsAlternately
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StringMerger merger = new StringMerger();

            Console.WriteLine(merger.MergeAlternately("abc", "pqr"));
        }
    }
}
