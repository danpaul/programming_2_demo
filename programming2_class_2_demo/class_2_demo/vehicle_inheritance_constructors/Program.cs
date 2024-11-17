namespace vehicle_inheritance_constructors
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
            Truck truck = new Truck(
                 40, // fuel capacity (Vehicle class)
                 80, // top speed (Vehicle class)
                 5800 // cargo capacity (Truck class)
             );
        }
    }
}
