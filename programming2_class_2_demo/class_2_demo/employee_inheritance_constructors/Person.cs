
namespace employee_inheritance_constructors
{
    public class Person
    {
        // define fields provided by the base class
        // use protected instead of private so the derived class has access to the fields
        protected string FirstName, LastName;
        protected DateTime DateOfBirth;

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
    }
}
