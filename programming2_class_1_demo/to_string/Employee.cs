
namespace to_string;

public class Employee
{
    public string FirstName
    {
        get;
        private set;
    }
    public string LastName
    {
        get;
        private set;
    }
    public decimal Salary
    {
        get;
        private set;
    }

    public Employee(string firstName, string lastName, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    // The ToString method is provided by a base class so we need to "override"
    //  it and use the "override" declaratoin in our method signature.
    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Salary}";
    }

}
