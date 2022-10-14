using System;
using System.Collections.Generic;
using EmployeeLibrary;
namespace EmployeeApplication
{
    

    public class Operations
    {
        public static void MainMenu()
        {
            List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
            string willing = "";
            do
            {
                System.Console.WriteLine("Enter the your name : ");
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

                System.Console.WriteLine("Do you to collect next employee details ?");
                willing = Console.ReadLine().ToLower();
                
                
            }while(willing=="yes");

            foreach(EmployeeDetails employee in employeeList )
            {
                System.Console.WriteLine("Employee details ");
                System.Console.WriteLine($"Employee ID is {employee.EmployeeID} \nEmployee Name is {employee.Name} \nEmployee worklocation is {employee.WorkLocation} \nEmployee team name is {employee.TeamName} \nEmployee date of joining is {employee.DateOfJoining.ToString("dd/MM/yyyy")} \nNumber of working days is {employee.WorkingDays} \nNumber of leaves taken by a leave in the month is {employee.LeavesTaken} \nEmployee is a {employee.Gender}");
                employee.CalculateSalary();
            }
        }
    }
}