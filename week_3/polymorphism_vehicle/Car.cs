
namespace polymorphism_vehicle
{
    public class Car : Vehicle
    {
        public Car(string name) : base(name) { }

        public override void Drive()
        {
            Console.WriteLine($"{Name} is driving on the road.");
        }

        public override void PerformService()
        {
            Console.WriteLine("Changing the oil in the car...");
        }
    }
}
