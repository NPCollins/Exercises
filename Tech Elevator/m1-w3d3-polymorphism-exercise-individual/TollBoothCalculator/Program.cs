using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMiles = 0;
            double totalCost = 0;
            List<IVehicle> vehicleList = new List<IVehicle>();
            List<int> distanceTraveled = new List<int>();
            List<double> tollList = new List<double>();
            List<string> vehicleNames = new List<string>();
            vehicleNames.Add("Sedan");
            vehicleNames.Add("BigRig");
            vehicleNames.Add("MoveIt");

            Car sedan = new Car(true);
            Truck bigRig = new Truck(16);
            Tank moveIt = new Tank();

            vehicleList.Add(sedan);
            vehicleList.Add(bigRig);
            vehicleList.Add(moveIt);

            Random rand = new Random();

            foreach (IVehicle vehicle in vehicleList)
            {
                int randomDistance = rand.Next(0, 501);
                distanceTraveled.Add(randomDistance);
                tollList.Add(vehicle.CalculateToll(randomDistance));
                totalCost += vehicle.CalculateToll(randomDistance);
                totalMiles += randomDistance;
            }

            Console.Write("Vehicle");
            Console.Write("Distance Traveled".PadLeft(20));
            Console.Write("Toll $".PadLeft(20));
            Console.WriteLine();
            Console.Write("-----------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write(vehicleNames[i]);
                Console.Write(distanceTraveled[i].ToString().PadLeft(20));
                Console.Write(tollList[i].ToString().PadLeft(20));
                Console.WriteLine();
            }
            Console.WriteLine("Total Miles Traveled: " + totalMiles);
            Console.WriteLine("Total Tollbooth Revenue: $" + totalCost);
        }
    }
}
