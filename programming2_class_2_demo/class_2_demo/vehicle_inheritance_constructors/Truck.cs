using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_inheritance_constructors
{
    internal class Truck : Vehicle
    {
        // change public to protected
        protected double CargoCapacity;

        // since a constructor with parameters is defined in the base class,
        //  we must define a constructor and call the base constructor
        public Truck(
            // parameters for the base class
            double fuelCapacity,
            double topSpeed,
            // paramter for the derived class
            double cargoCapacity
        ) : base(fuelCapacity, topSpeed)
        {
            // the base class constructor sets the FuelCapacity and TopSpeed fields
            // here we just set the CargoCapacity
            CargoCapacity = cargoCapacity;
        }
    }
}
