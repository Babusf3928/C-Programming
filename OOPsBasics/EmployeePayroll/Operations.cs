using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public static class Operations
    {
        static EmployeeDetails currentEmployee = null;

        static List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
        public static void MainMenu()
        {
            string choice = "yes";
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
            System.Console.WriteLine("Enter  your name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your role : ");
            string role = Console.ReadLine();
            System.Console.WriteLine("Enter your worklocation : ");
            WorkLocation workLocation = Enum.Parse<WorkLocation>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your team name : ");
            string teamName = Console.ReadLine();
            System.Console.WriteLine("Enter the date of joining in dd/MM/yyyy : ");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter the number of working days in a month : ");
            int workingDays = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the leaves taken : ");
            int leavesTaken = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your gender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            EmployeeDetails payroll = new EmployeeDetails(name,role,workLocation,teamName,dateOfJoining,workingDays,leavesTaken,gender);
            employeeList.Add(payroll);
            System.Console.WriteLine("Your Employee ID is "+payroll.EmployeeID);
        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your Employee ID ");
            string employeeID = Console.ReadLine();
            foreach(EmployeeDetails payroll in employeeList)
            {
                if(payroll.EmployeeID==employeeID)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentEmployee=payroll;
                    SubMenu();
                }
                else
                {
                    System.Console.WriteLine("Wrong pass");
                }
            }
        }

        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Submenu Options");
                System.Console.WriteLine("1.Show Details 2.Number of Leaves 3.Calculate Salary 4.Exit Submenu");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Details");
                        currentEmployee.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        currentEmployee.NumberOfLeavesTaken();
                        break;
                    }
                    case 3:
                    {
                        currentEmployee.CalculateSalary();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit Submenu");
                        choice = "no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        

    }
}