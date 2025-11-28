namespace employee_inheritance
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
            // create a new Person object and set the fields
            Person person = new Person()
            {
                FirstName = "Joe",
                LastName = "Joeson",
                DateOfBirth = new DateTime(1970, 1, 1)
            };

            // person.Department;

            // create a new Employee object and set fields
            Employee employee = new Employee()
            {
                // set fields inherited from person
                FirstName = "Jill",
                LastName = "Jilleson",
                DateOfBirth = new DateTime(1980, 1, 1),
                // set fields defined in dervied class
                Department = "IT",
                Salary = 1000000,
                EmployeeID = 123
            };

            // employee.

            // employee.FirstName = "Jill"

            // write the objects - this automatically class the ToString() methods
            Console.WriteLine(person);
            Console.WriteLine(employee);

        }
    }
}
