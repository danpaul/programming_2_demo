
namespace interface_animals
{
    internal class AnimalFeeder
    {
        // we can use interfaces as method parameters
        // this method can take any object that implements IAnimal
        public void Feed(IAnimal animal)
        {
            Console.WriteLine($"Feeding the animal {animal.GetType().Name} {animal.Weight * 0.1}kgs of food");
            animal.MakeSound();
            Console.WriteLine();
        }
    }
}
