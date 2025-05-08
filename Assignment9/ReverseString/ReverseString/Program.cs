// Written by Swornashabi
// 4/25/25

using System.Net.Security;

namespace ReverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();

            List<char> aList = new List<char>() { 'y', 'e', 'h' };

            List<char> result = aCalculator.ReverseString(aList);

            foreach(char c in result)
            {
                Console.WriteLine(c);
            }
        }
    }
}
