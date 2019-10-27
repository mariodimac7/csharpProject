using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing the regex
            //Console.WriteLine("What is your email address?");
            //string input = Console.ReadLine();
            //if (RegexValidation.IsValidEmail(input.ToLower))
            //{
            //    Console.WriteLine("Good one!");
            //}
            //else
            //{
            //    Console.WriteLine("Email address is invalid");
            //}
            //Console.ReadKey();

            Console.WriteLine($"#######################################\n" +
                $"##########        DBS        ##########\n" +
                $"#######################################\n\n" +
                $"Welcome to DBS\n\n");

            Console.WriteLine("Hi there! Are you a Teacher or a Student\n");
            string role = Console.ReadLine();

            while (role.ToUpper() != "TEACHER" && role.ToUpper() != "STUDENT")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nThis is not an option. Please enter \"Student\" or \"Teacher\"?\n ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                role = Console.ReadLine();
            }

            if(role.ToUpper() == "TEACHER")
            {
                //example with a teachers
                Teacher teacher = new Teacher();
                Address address = new Address();

                Console.WriteLine($"Welcome to the section for a teachers!\n" +
                    $"We will need just a few information from you,\n" +
                    $"Thanks in advance for your collaboration!\n\n");
                Console.WriteLine("Can you tell us your first name?\n");
                teacher.FirstName = Console.ReadLine();

              
                while (string.IsNullOrWhiteSpace(teacher.FirstName))
                {
                    Console.WriteLine("It seems you didn't enter anything. Can you try again?\n");
                    teacher.FirstName = Console.ReadLine();
                }

                Console.WriteLine("..and your last name?\n");
                teacher.LastName = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(teacher.LastName))
                {
                    Console.WriteLine("\nIt seems you didn't enter anything. Can you try again?\n");
                    teacher.LastName = Console.ReadLine();
                }

                Console.WriteLine($"\nPlease enter your phone number!");
                teacher.Phone = Console.ReadLine();
                
                while(RegexValidation.CheckNumber(teacher.Phone) == false)
                {
                    Console.WriteLine($"\nPhone number format is not valid! Can you enter your\n" +
                        "phone number with the country code, for example +3532345678?\n\n");
                    teacher.Phone = Console.ReadLine();
                }

                Console.WriteLine("\nWe will need also your email address.\n");
                teacher.Email = Console.ReadLine();

                while(!RegexValidation.IsValidEmail(teacher.Email))
                {
                    Console.WriteLine($"\nEmail number doesn't seem to be in the correct form.\n" +
                        $"Can you try again?");
                    teacher.Email = Console.ReadLine();
                }

                Console.WriteLine("Thanks for that! You're almost done with this form.\n" +
                    "Now we will need your full address. Lets go step by step\n" +
                    "What is your house number?\n");
                address.HouseNumber = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(address.HouseNumber))
                {
                    Console.WriteLine("\nIt seems you didn't enter anything. Can you try again?\n");
                    address.HouseNumber = Console.ReadLine();
                }



                Console.WriteLine("\nStreet?\n");
                address.Street = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(address.Street))
                {
                    Console.WriteLine("\nIt seems you didn't enter anything. Can you try again?\n");
                    address.Street = Console.ReadLine();
                }


                Console.WriteLine("\nCounty?\n");
                address.County = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(address.County))
                {
                    Console.WriteLine("\nIt seems you didn't enter anything. Can you try again?\n");
                    address.County = Console.ReadLine();
                }


                Console.WriteLine("\nCountry?\n");
                address.Country = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(address.Country))
                {
                    Console.WriteLine("\nIt seems you didn't enter anything. Can you try again?\n");
                    address.Country = Console.ReadLine();
                }


                Console.WriteLine("\nWhich subject will you teach this semestar?\n");
                teacher.SubjectTaught = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(teacher.SubjectTaught))
                {
                    Console.WriteLine("\nIt seems you didn't enter anything. Can you try again?\n");
                    teacher.SubjectTaught = Console.ReadLine();
                }


                Console.WriteLine($"\nYou have been amazing, thanks a lot for all the details!\n" +
                    $"Now at the end we have a small surprise for you. For all new and old teachers we give\n" +
                    $"a small bonus which is based on number of years you are working at DBS. To get more info\n" +
                    $"just enter the number of years you are working at DBS.\n");
                teacher.YearsInCompany = Int32.Parse(Console.ReadLine());

                while (string.IsNullOrWhiteSpace(teacher.YearsInCompany.ToString()))
                {
                    Console.WriteLine("It seems you didn't enter anything. Can you try again?\n");
                    teacher.YearsInCompany = Int32.Parse(Console.ReadLine());
                }

                if(teacher.YearsInCompany < 1)
                {
                    Console.WriteLine($"Hi {teacher.FirstName}, as this is your fist year here, you will not get any bonus\n" +
                        $"for the previous year, however you will get a welcome vaucher of 100£");
                     
                } else
                {
                    Console.WriteLine($"Hi {teacher.FirstName}, your bonus for this year is {teacher.Bonus(teacher.YearsInCompany)}£");
                }

                Console.WriteLine("\nPlease press any key to exit!\n");
                Console.ReadKey();
            }
            else
            {
                //this is the second part where I have added test data, if you test out the example
                //with the teacher you will have to provide the inputs by yourself

                Address addAd = new Address("164", "Main Street", "Dublin County", "Dublin");
                Student addStudent = new Student("Claire","Caulfield","+353851234567", "claire@dbs.ie", addAd, 1234567, StudentStatusEnum.Postgrad);

                Console.WriteLine($"\nWelcome to the section for students!\n" +
                   $"We have already got your deatails. Just check if everythings is correct.\n" +
                   $"If something is not correct, send us an email to info@dbs.ie\n");

                Console.WriteLine(addStudent.GreetPerson());
                Console.WriteLine(addStudent.ToString());
                Console.WriteLine(addStudent.SendSchedule());

                Console.WriteLine("\nPlease press any key to exit!\n");

                Console.ReadKey();
            }
           
        }
    }
}
