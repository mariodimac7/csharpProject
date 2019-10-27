using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Student : Person, IPerson
    {
        //attributes
        public int StudentID { get; set; }
        public StudentStatusEnum Status { get; set; }

        public Student()
        {

        }

        public Student(string fname, string lname, string phone, string email, Address address, int id, StudentStatusEnum status)
            :base(fname, lname, phone, email, address)
        {
            StudentID = id;
            Status = status;
        }

        public override string ToString()
        {
            return 
                $"Your current student status is {Status} and your new id is {StudentID}\n" +
                $"You will get additional information on your email {Email}\n" +
                $"or we will contact you on {Phone}.\n" +
                $"The address we have is:\n{Address}\n";
        }

        public string GreetPerson()
        {
            return $"Hello {FirstName} {LastName}, welcome to DBS!\n";
        }

        public string SendSchedule()
        {
            return $"{FirstName}, you are going to get your schedule in a few days.\n" +
                $"Please check your Moodle account for all the updates!\n";
        }
    }
}
