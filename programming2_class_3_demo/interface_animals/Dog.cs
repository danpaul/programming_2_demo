
namespace interface_animals
{
    // we declare that we are implementing the IAnimal interface
    // unlike abstract classes, it is possible to implement multiple interfaces
    public class Dog : IAnimal, ICanine
    {
        // we must implement Weight.get from IAnimal
        public double Weight { get; }

        // we must implement IsDomestic.get from ICanine
        public bool IsDomestic { get; }


        public Dog(double weight, bool isDomestic)
        {
            Weight = weight;
            IsDomestic = isDomestic;
        }

        // we must implement MakeSound() from IAnimal
        public void MakeSound()
        {
            if (IsDomestic)
            {
                Console.WriteLine("wooofff...");
            }
            else
            {
                Console.WriteLine("WOOOFF!!!");
            }
        }
    }
}
