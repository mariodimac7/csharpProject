using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Employee : Person
    {
        //attributes
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int phone, string email, double salary)
            :base(name, phone, email)
        {
            Salary = salary;
        }

    }
}
