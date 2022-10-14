using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class TeacherInfo:PersonalInfo
    {
        private static int s_teacherId=1000;
        public string TeacherID { get; }
        public string Department { get; set; }
        public string Subject { get; set; }
        public string  Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public TeacherInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string department,string subject,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,phone,mail,dob,gender)
        {
            s_teacherId++;
            TeacherID="TID"+s_teacherId;
            Department=department;
            Subject=subject;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowTeacher()
        {
            ShowDetails();
            System.Console.WriteLine($"The teacher Id is {TeacherID}\nDepartment is {Department}\nSubject is {Subject}\nQualifaication is {Qualification}\nYear of experience is {YearOfExperience}\nThe date of joining is {DateOfJoining}");
        }
    }
}