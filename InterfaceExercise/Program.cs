using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var civic = new Car { HasTrunk = true, AutoTransmission = false, TypeOfFuel = "Gas", Color = "Blue", NumberOfDoors = 2, NumberOfWheels = 4, Name = "ABC Comapny", HasFleet = true };
            var f150 = new Truck { HasBedLiner = false, TowCapacity = 6000, TypeOfFuel = "Diesel", Color = "White", NumberOfDoors = 2, NumberOfWheels = 4, Name = "XZY LLC", HasFleet = false };
            var crv = new SUV { HasRoofRack = true, RemovableSeats = false, TypeOfFuel = "Hybrid", Color = "Silver", NumberOfDoors = 5, NumberOfWheels = 4, Name = "Easy Inc", HasFleet = true };

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            civic.DisplayDetails("Civic");
            f150.DisplayDetails("F-150");
            crv.DisplayDetails("CRV");

            Console.ReadKey();
        }
    }
}
