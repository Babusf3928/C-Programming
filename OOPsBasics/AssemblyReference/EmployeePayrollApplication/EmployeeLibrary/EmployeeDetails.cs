using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public enum WorkLocation{Default,Madura,Eymard}

    public enum Gender{Default,Male,Female,Transgender}
    public class EmployeeDetails
    {
        private static int s_employeeID=1000;

        public string EmployeeID { get; }
        public string Name { get; set; }
        public string Role { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int WorkingDays { get; set; }
        public int LeavesTaken { get; set; }
        public Gender Gender { get; set; }
        
        

        public EmployeeDetails(string name,string role,WorkLocation workLocation,string teamName,DateTime dateOfJoining,int workingDays,int leavesTaken,Gender gender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            Name=name;
            Role=role;
            WorkLocation=workLocation;
            TeamName=teamName;
            DateOfJoining=dateOfJoining;
            WorkingDays=workingDays;
            LeavesTaken=leavesTaken;
            Gender=gender;
        }

        public void CalculateSalary()
        {
            int salary = (WorkingDays-LeavesTaken)*500;
            System.Console.WriteLine("The Employee's salary is : "+salary+" Rupees.");
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}