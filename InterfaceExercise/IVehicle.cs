﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string TypeOfFuel { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public void DisplayDetails(string model);
    }
}
