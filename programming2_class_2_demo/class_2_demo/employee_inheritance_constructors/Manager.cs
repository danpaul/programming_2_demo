
namespace employee_inheritance_constructors
{
    // Manager inherits from Employee which inherits from Person
    // Manager will therefore inherit all Employee and Person members
    internal class Manager : Employee
    {
        public Manager(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string department,
            int salary,
            int employeeID
        // pass all constructor paramters through to the base class (Employee)
        ) : base(firstName, lastName, dateOfBirth, department, salary, employeeID)
        { }
        public void HireEmployee(Employee employee)
        {
            Console.WriteLine("Congratulations, you got the job!");
        }

        // since we are overriding the inherited method, we must use
        //  use the override keywokd
        public override void IncreaseSalary(int amount)
        {
            Salary += amount * 2;
            // alternatively, we could make this update through our base class:
            // base.IncreaseSalary(amount * 2);
        }
    }
}
