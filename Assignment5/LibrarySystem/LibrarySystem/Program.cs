// Written by Swornashabi
// 2/27/2025

namespace LibrarySystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EBook aEBook = new EBook("Voices", "Tim Burner", 1989, 300);
            Console.WriteLine(aEBook.ToString());

            PrintedBook aPrintedBook = new PrintedBook("Echoes", "Claire Waldorf", 2001, 341);
            Console.WriteLine(aPrintedBook.ToString());
        }
    }
}
