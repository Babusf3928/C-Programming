using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_registernumber=1000;
        public string RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }

        public  StudentInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string standard,string branch,int academicYear):base(name,fatherName,phone,mail,dob,gender)
        {
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"Your name is {Name}\nYour father name is {FatherName}\nYour phone number is {Phone}\nYour mail ID is {Mail}\nYour date of birth is {DOB}\nYour gender is {Gender}\nYour standard is {Standard}\nYour branch is {Branch}\nYour academic year is {AcademicYear}");
        }
    }
}