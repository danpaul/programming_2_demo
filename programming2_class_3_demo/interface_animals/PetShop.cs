
namespace interface_animals
{
    public class PetShop
    {
        Random random = new Random();

        // It is possible to use an interface as a return type.
        // This method must return an object that implementes the IAnimal interface
        //  and so can return anything that implements that interface.
        public IAnimal GetNewPet()
        {
            if (random.Next(0, 2) == 1)
            {
                return new Cat(2);
            }
            else
            {
                return new Dog(5, true);
            }
        }
    }
}
