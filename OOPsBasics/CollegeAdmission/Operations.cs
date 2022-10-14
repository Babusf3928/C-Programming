using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public static class Operations
    {

        static StudentDetail currentStudent=null;
        static List<StudentDetail> studentList=new List<StudentDetail>();
        public static void MainMenu()
        {
            string choice ="yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice = "no";
                        break;
                    }
                }
            }while(choice =="yes");
        }

        public static void Registration()

        {
            System.Console.WriteLine("Enter your name : ");
                string name = Console.ReadLine();
                System.Console.WriteLine("Enter your father's name : ");
                string fatherName = Console.ReadLine();
                System.Console.WriteLine("Enter your date of birth in dd/MM/yyyy : ");
                DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                System.Console.WriteLine("Enter your gender : ");
                Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
                System.Console.WriteLine("Enter your phone number : ");
                long phone = long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your mail ID : ");
                string mail = Console.ReadLine();
                System.Console.WriteLine("Enter your physics mark : ");
                int physics = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your chemistry mark : ");
                int chemistry = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your maths mark : ");
                int maths = int.Parse(Console.ReadLine());

                StudentDetail student1 = new StudentDetail(name,fatherName,dob,gender,phone,mail,physics,chemistry,maths);
                studentList.Add(student1);
                System.Console.WriteLine("Your Application number is "+student1.ApplicationNumber);

        } 

        public static void Login()
        {
            System.Console.WriteLine("Enter your Application Number");
            int applicationNumber = int.Parse(Console.ReadLine());
            foreach(StudentDetail student1 in studentList)
            {
                if(student1.ApplicationNumber == applicationNumber)
                {
                    System.Console.WriteLine("Login Successfull");
                    currentStudent=student1;
                    SubMenu();
                }
            }
        }

        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Submenu Options");
                System.Console.WriteLine("1.Show Details, 2.Check Eligibility, 3.Exit Submenu");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Details");
                        currentStudent.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Check Eligibility");
                        bool eligible = currentStudent.ChechEligibility(75.0);

                        if(eligible)
                        {
                            System.Console.WriteLine("You are Eligible");
                        }
                        else
                        {
                            System.Console.WriteLine("You are not Eligible");
                        }
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit Submenu");
                        choice = "no";
                        break;
                    }
                }
            }while(choice =="yes");

        }


    }
}