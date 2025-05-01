namespace TheDefenseOfConsolas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // input of targeted rows and column
            Console.WriteLine("Target Row?");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Target Column?");
            int column = int.Parse(Console.ReadLine());

            //printing defense mechanism
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row - 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");

            Console.Beep();
        }
    }
}
