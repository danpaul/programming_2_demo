
namespace to_string;

public class Employee
{
    public string FirstName = "";
    public string LastName = "";

    public uint Salary = 0;

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Salary}";
    }

}
