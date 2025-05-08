// Written by Swornashabi
namespace SegmentsInString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SegmentCounter counter = new SegmentCounter();

            Console.WriteLine(counter.CountSegments("Hello, my name is John"));
        }
    }
}
