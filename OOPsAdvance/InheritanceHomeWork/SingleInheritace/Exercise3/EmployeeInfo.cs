using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public enum Gender{Default,Male,Female,Transgender}
    public class EmployeeInfo:SalaryInfo
    {
        private static int s_employeeId=1000;
        public string EmploymentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Branch { get; set; }

        public EmployeeInfo(DateTime date,int numberOfHoursWorked,double salaryOfTheMonth,string month,string name,string fatherName,Gender gender,long mobile,DateTime dob,string branch):base(date,numberOfHoursWorked,salaryOfTheMonth,month)
        {
            s_employeeId++;
            EmploymentID="SF"+s_employeeId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Branch=branch;      
        }

        public void ShowEmployee()
        {
            System.Console.WriteLine($"Your employee ID is {EmploymentID} Your name is {Name}\nYour father name is {FatherName}\nYour gender is {Gender}\nYour mobile numbe is {Mobile}\nYour date of birth is {DOB.ToString("dd/MM/yyyy")}\nYour branch is {Branch}");
            Salary();
            
        }
    }
}