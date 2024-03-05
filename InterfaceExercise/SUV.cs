using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasRoofRack { get; set; }
        public bool RemovableSeats { get; set; }
        public int NumberOfWheels { get ; set; }
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
            Console.WriteLine("Has Rook Rack...: " + ((HasRoofRack) ? "Yes" : "No"));
            Console.WriteLine("Removable Seats.: " + ((RemovableSeats) ? "Yes" : "No"));
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Fuel............: {TypeOfFuel}");
            Console.WriteLine($"Number of Doors.: {NumberOfDoors}");
            Console.WriteLine($"Owner...........: {Name}");
            Console.WriteLine($"Company Fleet...: {HasFleet}");
            Console.WriteLine();
        }
    }
}
