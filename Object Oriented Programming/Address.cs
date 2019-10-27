using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Address
    {
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string County { get; set; }
        public string Country { get; set; }

        public Address()
        { }

        public Address(string no, string street, string county, string country)
        {
            HouseNumber = no;
            Street = street;
            County = county;
            Country = country;
        }

        public override string ToString()
        {
            return $"{HouseNumber} {Street}, \n{County}, \n{Country}";
        }
    }
}
