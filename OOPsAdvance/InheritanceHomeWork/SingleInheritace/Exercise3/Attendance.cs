using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Attendance
    {
        public DateTime Date { get; set; }
        public int NumberOfHoursWorked { get; set; }

        public Attendance(DateTime date,int numberOfHoursWorked)
        {
            Date=date;
            NumberOfHoursWorked=numberOfHoursWorked;
        }

        public void GetAttendance()
        {
            System.Console.WriteLine($"The Date is {Date.ToString("dd/MM/yyyy")}\nThe number of working hours is {NumberOfHoursWorked}");
        }
    }
}