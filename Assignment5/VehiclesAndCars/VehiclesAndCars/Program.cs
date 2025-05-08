// Written by Swornashabi
// 2/26/2025

namespace VehiclesAndCars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle aVehicle = new Vehicle("Nissan", "SUV10", 1991);
            Console.WriteLine(aVehicle.ToString());

            Car aCar = new Car("Toyota", "AWD206", 1864);
            aCar.NumOfDoors = 4;
            Console.WriteLine(aCar.ToString());

            Motorcycle aMotorcycle = new Motorcycle("Honda", "FIREX10", 1967);
            aMotorcycle.HasSidecar = true;
            Console.WriteLine(aMotorcycle.ToString());
        }
    }
}
