using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Object_Oriented_Programming
{
    class Person
    {
        //attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

        public Person()
        {

        }

        public Person(string fname, string lname, string phone, string email, Address address)
        {
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Email = email;
            Address = address;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
