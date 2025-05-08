// Written by Swornashabi
namespace Question3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PivotIndexFinder finder = new PivotIndexFinder();

            Console.WriteLine(finder.PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 }));
            Console.WriteLine(finder.PivotIndex(new int[] { 1, 2, 3 }));
            Console.WriteLine(finder.PivotIndex(new int[] { 2, 1, -1 }));
        }
    }
}
