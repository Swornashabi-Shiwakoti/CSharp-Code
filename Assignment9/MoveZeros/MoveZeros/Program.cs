// Written by Swornashabi
namespace MoveZeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int> { 0, 1, 0, 3, 12 };

            Calculator aCalculator = new Calculator();

            List<int> result = aCalculator.MoveZeros(nums);

            foreach(int num in result)
            {
                Console.WriteLine(num);

            }

        }
    }
}
