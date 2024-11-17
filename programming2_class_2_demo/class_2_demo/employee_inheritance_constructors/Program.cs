using System;

namespace employee_inheritance_constructors
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
            // create a new Person object and set the fields using the constructor
            Person person = new Person(
                "Joe", // firstname
                "Joeson", // lastname
                new DateTime(1970, 1, 1) // date of birth
            );

            // create a new Employee object and set fields
            Employee employee = new Employee(
                // base class fields
                "Jill", // firstname
                "Jilleson", // lastname
                new DateTime(1980, 1, 1), // date of birth
                                          // derived class fields
                "IT", // department
                50000, // salary
                123 // id
            );

            // create a new Manager object
            Manager manager = new Manager(
                // base class fields
                "Mister", // firstname
                "Manager", // lastname
                new DateTime(1990, 1, 1), // date of birth
                "IT", // department
                50000, // salary
                456 // id 
            );

            // update employee salary
            employee.IncreaseSalary(10000);
            // update employe salary
            manager.IncreaseSalary(10000);

            // display salarys
            employee.DisplaySalary();
            manager.DisplaySalary();
        }
    }
}
