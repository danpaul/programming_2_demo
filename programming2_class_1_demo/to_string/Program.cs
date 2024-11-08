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
        Employee jimmyJazz = new Employee() { FirstName = "Jimmy", LastName = "Jazz", Salary = 100000 };
        // since the Employee class has an override `ToString()` method defined, we can 
        Console.WriteLine(jimmyJazz);
        // the following is equivalent
        Console.WriteLine(jimmyJazz.ToString());
    }
}
