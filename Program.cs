using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703__hw___CarInGarageWithNewException
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> carTypes = new List<string> { "Mazda 6", "Mitzubishi Lancer", "Mitzubishi OutLander", "Subaro Station" };
            Garage<Car> gCars = new Garage<Car>(carTypes);
            List<string> bikeTypes = new List<string> { "Mazda 6", "Mitzubishi Lancer", "Mitzubishi OutLander", "Subaro Station" };
            Garage<Car> gBikes = new Garage<Car>(bikeTypes);
            Car c = new Car("Mazda 6", true, false);
            Car c1 = new Car("Mazda 6", false, true);
            Car c2 = new Car("Mazda 6", false, false);
            Car c3 = new Car("Mazda 6", true, true);
            gCars.AddVehicle(c);
            gCars.AddVehicle(c1);
            gCars.AddVehicle(c2);
            gCars.AddVehicle(c3);
            Console.WriteLine(gCars);
        }
    }
}
