// Written by Swornashabi
// 4/25/25
namespace MajorityElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();

            List<int> aList = new List<int>() { 3, 2, 3 };

            Console.WriteLine(aCalculator.GetMajorityElement(aList));
        }
    }
}
