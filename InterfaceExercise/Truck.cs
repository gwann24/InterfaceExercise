using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasBedLiner { get; set; }
        public int TowCapacity { get; set; }
        public int NumberOfWheels { get; set; }
        public string TypeOfFuel { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public bool HasFleet { get; set; }
        public void DisplayDetails(string model)
        {
            Console.WriteLine(model);
            Console.WriteLine($"Vehicle Type....: {GetType().Name}");
            Console.WriteLine($"Color...........: {Color}");
            Console.WriteLine("Has Bed Liner...: " + ((HasBedLiner) ? "Yes" : "No"));
            Console.WriteLine($"Tow Capacity....: {TowCapacity} lbs");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Fuel............: {TypeOfFuel}");
            Console.WriteLine($"Number of Doors.: {NumberOfDoors}");
            Console.WriteLine($"Owner...........: {Name}");
            Console.WriteLine($"Company Fleet...: {HasFleet}");
            Console.WriteLine();
        }
    }
}
