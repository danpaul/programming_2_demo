using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_inheritance
{
    // Employee derives from Person
    // Employee will inherit all person fields
    internal class Employee : Person
    {
        public string Department;
        public int Salary;
        public int EmployeeID;
    }
}
