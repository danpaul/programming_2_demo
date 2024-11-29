
namespace polymorphism_vehicle
{
    public class Bike : Vehicle
    {
        public Bike(string name) : base(name) { }

        public override void Drive()
        {
            Console.WriteLine($"{Name} is pedalling on the bike path.");
        }

        public override void PerformService()
        {
            Console.WriteLine("Oiling the bike chain and inflating the tires...");
        }
    }

}
