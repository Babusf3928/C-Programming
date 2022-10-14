using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Department{Default,EEE,CSE,ECE}
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentId=1000;
        public string StudentID { get; }
        public Department Department { get; set; }
        public string Year { get; set; }

        public StudentDetails(string aadhar,string name,string fatherName,Gender gender,long phone,Department department,string year):base( aadhar, name, fatherName, gender, phone)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            Year=year;
        }

        public void ShowStudent()
        {
            System.Console.WriteLine($"Student ID is {StudentID} ");
            ShowDetails();
            System.Console.WriteLine($"Department is {Department}\nYear is {Year}");
        }

    }
}