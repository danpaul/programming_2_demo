namespace interface_animals
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

            /**
             * Part 1
             */
            Cat cookie = new Cat(3);
            Dog fido = new Dog(5, true);
            Dog kujo = new Dog(25, false);

            // since .Weight is defined on the IAnimal interfaces, we are
            //  guaranteed to have access to it
            Console.WriteLine($"Cookie weighs {cookie.Weight} kilos");
            Console.WriteLine($"Fido weighs {fido.Weight} kilos");
            Console.WriteLine($"Kujo weighs {kujo.Weight} kilos");
            Console.WriteLine();

            // since .MakeSound() is defined on the IAnimal interface, we
            //  are guaranteed to have access to it
            cookie.MakeSound();
            fido.MakeSound();
            kujo.MakeSound();
            Console.WriteLine();


            /**
             * Part 2
             */

            // we can use an interface as a variable type
            // this variable can hold any object that implements the IAnimal interface
            IAnimal animal1;

            PetShop petShop = new PetShop();

            // petShop.GetNewPet() returns an object that implements IAnimal
            animal1 = petShop.GetNewPet();
            IAnimal animal2 = petShop.GetNewPet();
            IAnimal animal3 = petShop.GetNewPet();

            // we don't know if these animals are Cat or Dog objects but we do know
            //  they have implemented the IAnimal interface and so will have the MakeSound() method
            animal1.MakeSound();
            animal2.MakeSound();
            animal3.MakeSound();
            Console.WriteLine();

            // return;

            AnimalFeeder animalFeeder = new AnimalFeeder();

            // animalFeeder.Feed() takes an IAnimal as its parameter
            animalFeeder.Feed(animal1);
            animalFeeder.Feed(animal2);
            animalFeeder.Feed(animal3);

        }
    }
}
