namespace vehicle_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            // create a new Truck which inherits from Vehicle

            Truck truck = new Truck()
            {
                // set fields derived from base Vehicle class
                FuelCapacity = 100,
                TopSpeed = 80,
                // set field unique to Truck class
                CargoCapacity = 7500
            };

            Console.WriteLine(truck);
        }
    }
}
