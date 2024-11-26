using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_vehicle
{
    public abstract class Vehicle : IServiceable
    {
        public string Name { get; set; }

        public Vehicle(string name)
        {
            Name = name;
        }

        // Common behavior shared by all vehicles
        public void Start() => Console.WriteLine($"{Name} is starting.");
        public void Stop() => Console.WriteLine($"{Name} is stopping.");

        // Abstract method to be implemented by specific vehicles
        public abstract void Drive();

        // Implement IServiceable
        public abstract void PerformService();
    }
}
