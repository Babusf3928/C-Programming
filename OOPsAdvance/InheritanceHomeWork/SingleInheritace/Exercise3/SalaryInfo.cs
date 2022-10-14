using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class SalaryInfo:Attendance
    {
        public double SalaryOfTheMonth { get; set; }
        public string Month { get; set; }

        public SalaryInfo(DateTime date,int numberOfHoursWorked,double salaryOfTheMonth,string month):base(date,numberOfHoursWorked)
        {
            SalaryOfTheMonth=salaryOfTheMonth;
            Month=month;
        }

        public void Salary()
        {
            GetAttendance();
            System.Console.WriteLine($"Your salary of the month is {SalaryOfTheMonth}\nThe month is {Month}");
        }
    }
}