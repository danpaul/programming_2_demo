using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_inheritance_constructors
{
    // Employee derives from Person
    // Employee will inherit all person fields
    internal class Employee : Person
    {
        // we can also use protected for these fields in case we derive
        //  another class from it in the future
        protected string Department;
        protected int Salary;
        protected int EmployeeID;

        public Employee(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string department,
            int salary,
            int employeeID
        // we use `base` to call our base constructor (in Vehicle)
        // if a constructor with parameters is defined in the base class, we _must_ call it
        ) : base(firstName, lastName, dateOfBirth)
        {
            // the base class constructor will handle setting the fields: FirstName, LastName, DateOfBirth

            // we still need to set the unique Employee fields here
            Department = department;
            Salary = salary;
            EmployeeID = employeeID;
        }

        // create a method which can be overriden (redefined) in the derived
        //  class using the virtual keyword
        public virtual void IncreaseSalary(int amount)
        {
            Salary += amount;
        }

        // since this method does not use the virtual keyword, it will be inherited
        //  by derived classes but can't be overridden
        public void DisplaySalary()
        {
            Console.WriteLine($"{FirstName} {LastName}, salary: {Salary}");
        }
    }
}
