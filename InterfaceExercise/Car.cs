using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool AutoTransmission { get; set; }
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
            Console.WriteLine("Has a Trunk.....: " + ((HasTrunk) ? "Yes" : "No"));
            Console.WriteLine("Transmission....: " + ((AutoTransmission) ? "Automatic" : "Manual"));
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Fuel............: {TypeOfFuel}");
            Console.WriteLine($"Number of Doors.: {NumberOfDoors}");
            Console.WriteLine($"Owner...........: {Name}");
            Console.WriteLine($"Company Fleet...: {HasFleet}");
            Console.WriteLine();
        }
    }
}
