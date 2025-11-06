namespace to_string;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // Demonstrating overriding ToString() method
        // View the Employee class for implementation
        Employee jimmyJazz = new Employee("Jimmy", "Jazz", 1000000);

        // We can explicitly invoke the ToString() method 
        Console.WriteLine(jimmyJazz.ToString());

        // If we pass the object to Console.WriteLine, this method
        //  will get invoked implicitly.
        Console.WriteLine(jimmyJazz);
        
    }
}
