// Written by Swornashabi
namespace Question5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SandwichProblem problem = new SandwichProblem();

            int[] students1 = { 1, 1, 0, 0 };
            int[] sandwiches1 = { 0, 1, 0, 1 };
            Console.WriteLine(problem.CountStudents(students1, sandwiches1));

            int[] students2 = { 1, 1, 1, 0, 0, 1 };
            int[] sandwiches2 = { 1, 0, 0, 0, 1, 1 };
            Console.WriteLine(problem.CountStudents(students2, sandwiches2));
        }
    }
}
