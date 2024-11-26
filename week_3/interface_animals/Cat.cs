
namespace interface_animals
{
    // we declare that we are implementing the IAnimal interface
    internal class Cat : IAnimal
    {
        // we must implement Weight.get
        public double Weight { get; }
        public Cat(double weight)
        {
            Weight = weight;
        }

        // we must implement MakeSound()
        public void MakeSound()
        {
            Console.WriteLine("meeoowwww...");
        }
    }
}
