
namespace interface_animals
{
    internal class AnimalFeeder
    {
        // we can use interfaces as method parameters
        // this method can take any object that implements IAnimal
        public void Feed(IAnimal animal)
        {
            Console.WriteLine($"Feeding the animal {animal.GetType().Name} {animal.Weight * 0.1}kgs of food");

            // check type and conditionally cast back to Dog
            if (animal.GetType().Name == "Dog")
            {
                Dog dog = (Dog)animal;
                if (dog.IsDomestic)
                {
                    Console.WriteLine("Domestic dog receieved dog food.");
                }
                else
                {
                    Console.WriteLine("Wild dog received meat.");
                }
            }

            animal.MakeSound();
            Console.WriteLine();
        }
    }
}
