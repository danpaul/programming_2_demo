using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_inheritance
{
    public class Person
    {
        public string FirstName, LastName;
        public DateTime DateOfBirth;


        // define an override ToString() method listing basic person info
        public override string ToString()
        {
            return $"Name: {LastName}, {FirstName}; DOB: {DateOfBirth}";
        }
    }

}
