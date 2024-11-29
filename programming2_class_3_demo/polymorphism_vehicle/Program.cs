namespace polymorphism_vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo code for polymorphism, interfaces, abstract classes
            // 
            // 1. Define an interface for serviceable entities: IServiceable
            // 2. Create an abstract class for vehicles: Vehicle
            // 3. Specific vehicle implementations: Car, Bike
            // 4. Polymorphism in action: VehicleManager

            Vehicle car = new Car("Toyota Corolla"); // Abstract class and polymorphism
            Vehicle bike = new Bike("Gezelle");

            VehicleManager manager = new VehicleManager();

            // Test driving vehicles
            manager.TestDrive(car);
            manager.TestDrive(bike);

            Console.WriteLine();

            // Servicing vehicles using interface
            manager.ServiceVehicle(car); // Using IServiceable interface
            manager.ServiceVehicle(bike);
        }
    }
}
