namespace vehicles_review
{
    using System;
    using System.Collections.Generic;

    /**
     * NOTE!!! We are putting enverything in a single file for demo/review.
     * When programming assignments, you should never do this
     */

    // Define an interface
    public interface IVehicle
    {
        void Start();
        void Stop();
        string GetDetails();
    }

    // Define an abstract class
    public abstract class Vehicle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        protected Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public abstract void Start(); // Abstract method
        public abstract void Stop();  // Abstract method

        public virtual string GetDetails() // Virtual method
        {
            return $"{Brand} {Model}";
        }
    }

    // Define a concrete class that extends the abstract class
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int numberOfDoors)
            : base(brand, model)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void Start()
        {
            Console.WriteLine($"{GetDetails()} (Car) is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{GetDetails()} (Car) is stopping.");
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", {NumberOfDoors} doors";
        }
    }

    // Define another concrete class
    public class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }

        public Bike(string brand, string model, bool hasCarrier)
            : base(brand, model)
        {
            HasCarrier = hasCarrier;
        }

        public override void Start()
        {
            Console.WriteLine($"{GetDetails()} (Bike) is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{GetDetails()} (Bike) is stopping.");
        }

        public override string GetDetails()
        {
            return base.GetDetails() + (HasCarrier ? ", with carrier" : ", no carrier");
        }
    }

    // Main program
    public class Program
    {
        public static void Main()
        {
            // Create a list of vehicles
            List<IVehicle> vehicles = new List<IVehicle>
            {
                new Car("Toyota", "Corolla", 4),
                new Bike("Yamaha", "MT-15", true)
            };

            // Start and stop each vehicle
            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.Start();
                vehicle.Stop();
                Console.WriteLine(vehicle.GetDetails());
            }

            Console.WriteLine();

            // Use a dictionary to store vehicles by ID
            Dictionary<int, IVehicle> vehicleDictionary = new Dictionary<int, IVehicle>
            {
                { 1, new Car("Honda", "Civic", 4) },
                { 2, new Bike("Hero", "Splendor", false) }
            };

            // Access and display vehicles using their ID
            foreach (var key in vehicleDictionary.Keys)
            {
                Console.WriteLine($"Vehicle ID {key}: {vehicleDictionary[key].GetDetails()}");
            }
        }
    }

}
