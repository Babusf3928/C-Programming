using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentId=1000;
        public string StudentID { get; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }

        public StudentInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string degree,string department,int semester):base(name,fatherName,phone,mail,dob,gender)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            Semester=semester;
        }

        public void StudentDetail()
        {
            ShowDetails();
            System.Console.WriteLine($"Your student ID is {StudentID}\nYour Department is {Department}\nYour semester is {Semester}");
        }
    }
}