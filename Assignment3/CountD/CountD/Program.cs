// Written by Swornashabi
// 2/16/2025

namespace CountD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string aString1 = "My Friend Dylan got distracted in school";

            Calculator aCalculator = new Calculator();

            int result = aCalculator.CountDs(aString1);
            Console.WriteLine(result);
        }
    }
}
