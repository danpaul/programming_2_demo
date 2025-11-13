
namespace employee_inheritance
{
    // Employee derives from Person
    // Employee will inherit all person's members (fields, properties and methods)
    internal class Employee : Person
    {
        public string Department;
        public int Salary;
        public int EmployeeID;

        // define an override ToString() method employee info
        // NOTE: we are invoking the ToString() method in the parent class use base.ToString().
        //  This allows us to display the basic person info without repeating the code.
        public override string ToString()
        {
            return $"{base.ToString()}; Department: {Department}; Salary: {Salary}; Employee ID: {EmployeeID}";
        }
    }
}
