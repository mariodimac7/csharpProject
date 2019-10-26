using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Teacher : Employee
    {
        //attributes
        public string SubjectTaught { get; set; }


        public Teacher()
        {

        }

        public Teacher(string name, int phone, string email, double salary, string subject)
            :base(name,phone,email,salary)
        {
            SubjectTaught = subject;
        }
    }
}
