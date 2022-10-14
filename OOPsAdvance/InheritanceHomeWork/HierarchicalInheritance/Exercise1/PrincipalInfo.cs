using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalID=1000;
        public string PrincipalID { get; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public PrincipalInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,phone,mail,dob,gender)
        {
            s_principalID++;
            PrincipalID="PID"+s_principalID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }

        public void ShowPrincipal()
        {
            ShowDetails();
            System.Console.WriteLine($"Principal ID is {PrincipalID}\nQualification is {Qualification}\nYear of Experience is {YearOfExperience}\nDate of joining is {DateOfJoining} ");
        }
    }
}