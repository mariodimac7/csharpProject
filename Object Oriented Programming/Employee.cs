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
        public int Age { get; set; }

        public Employee()
        {

        }

        public Employee(string fname, string lname, string phone, string email, Address address, double salary, int age)
            :base(fname, lname, phone, email, address)
        {
            Salary = salary;
            Age = Age;
        }

    }
}
