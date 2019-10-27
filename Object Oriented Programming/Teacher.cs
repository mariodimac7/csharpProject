using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Teacher : Employee, IPerson
    {
        //attributes
        public string SubjectTaught { get; set; }
        public int YearsInCompany { get; set; }

        public Teacher()
        {

        }

        public Teacher(string fname,string lname, string phone, string email, Address address, double salary, int age, string subject, int yearsincompany)
            :base(fname,lname,phone,email,address,salary,age)
        {
            SubjectTaught = subject;
            YearsInCompany = yearsincompany;
        }

        public int Bonus(int yearsincompany)
        {
            int bonus = 0;

            if (YearsInCompany < 1)
            {

               return bonus;
            }
            else
            {
                bonus = YearsInCompany * 200;
                return bonus;
            }
            
        }

        public string GreetPerson()
        {
            if (YearsInCompany < 1)
            {
                return $"Hello {FirstName}, welcome to DBS" +
                    $"We and our students are very happy you joined us";
            }
            else
            {
                return $"Hello {FirstName}, welcome back to DBS!";
            }
           
        }

        public string SendSchedule()
        {
            return $"Hello {FirstName}, the schedule for {SubjectTaught} will be ready in a few days" +
                $"We will send it to your email address";
        }
    }
}
