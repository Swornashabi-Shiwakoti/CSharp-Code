namespace Robot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RobotMovement robot = new RobotMovement();

            Console.WriteLine(robot.JudgeCircle("UD"));
        }
    }
}
