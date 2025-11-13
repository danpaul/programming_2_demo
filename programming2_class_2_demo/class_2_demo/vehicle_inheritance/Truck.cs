
namespace vehicle_inheritance
{
    // Truck inherits from Vehicle, so it will inherit the
    //  FuelCapacity and TopSpeed fields

    internal class Truck : Vehicle
    {
        public double CargoCapacity;

        // call parent class (Vehicle) ToString() method from child class
        public override string ToString()
        {
            return $"{base.ToString()}; Cargo Capacity: {CargoCapacity}";
        }
    }
}
