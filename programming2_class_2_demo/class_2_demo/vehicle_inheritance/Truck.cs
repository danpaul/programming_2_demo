using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_inheritance
{
    // Truck inherits from Vehicle, so it will inherit the
    //  FuelCapacity and TopSpeed fields

    internal class Truck : Vehicle
    {
        public double CargoCapacity;
    }
}
