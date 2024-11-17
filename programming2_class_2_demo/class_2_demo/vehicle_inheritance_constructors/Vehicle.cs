using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_inheritance_constructors
{
    internal class Vehicle
    {
        // chance public field to protected
        protected double FuelCapacity;
        protected double TopSpeed;

        // add a constructor
        public Vehicle(double fuelCapacity, double topSpeed)
        {
            FuelCapacity = fuelCapacity;
            TopSpeed = topSpeed;
        }
    }
}
