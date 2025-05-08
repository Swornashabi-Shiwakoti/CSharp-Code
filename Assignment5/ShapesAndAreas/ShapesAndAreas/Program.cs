namespace ShapesAndAreas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle aRectangle = new Rectangle("pink", 2.0, 3.0);
            Console.WriteLine(aRectangle.ToString());

            Circle aCircle = new Circle("blue", 7.0);
            Console.WriteLine(aCircle.ToString());

        }
    }
}
