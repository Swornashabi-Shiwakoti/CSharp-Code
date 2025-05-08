//Written by Swornashabi
//2/3/2025
namespace Watchtower
{
    public class Program
    {
       public static void Main(string[] args)
        {
            // creating a new watchtower
            Watchtower aWatchTower = new Watchtower();

            //providing coordinates
            aWatchTower.XCoordinate = -1;
            aWatchTower.YCoordinate = 0;

            //printing direction
            Console.WriteLine(aWatchTower.ToString());

        }
    }
}
