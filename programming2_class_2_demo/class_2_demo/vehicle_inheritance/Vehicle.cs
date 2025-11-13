using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_inheritance
{
    internal class Vehicle
    {
        public double FuelCapacity;
        public double TopSpeed;

        public override string ToString()
        {
            return $"Fuel Capacity: {FuelCapacity}; Top Speed: {TopSpeed}";
        }
    }
}
