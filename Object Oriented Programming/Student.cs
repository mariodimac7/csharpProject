using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Student : Person
    {
        //attributes
        public int StudentID { get; set; }
        public StudentStatusEnum Status { get; set; }

        public Student()
        {

        }

        public Student(string name, int phone, string email, int id, StudentStatusEnum status)
            :base(name, phone, email)
        {
            StudentID = id;
            Status = status;
        }

        public override string ToString()
        {
            return $" Hi {Name}, thank you for providing all the information!\n." +
                $"Your current student status is {Status} and your new id is {StudentID}" +
                $"You will get additional information on your email {Email} or we will contact you on {Phone}";
        }

    }
}
