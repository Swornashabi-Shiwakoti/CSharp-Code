// Written by Swornashabi
// 4/26/2025

namespace LengthOfTheLastWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            string s = "  fly me to the moon ";

            Console.WriteLine(aCalculator.LengthOfLastWord(s));
        }
    }
}
