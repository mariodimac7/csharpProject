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
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public Person()
        {

        }

        public Person(string name, int phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
