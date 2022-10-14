using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"Your name is {Name}\nYour father name is {FatherName}\nYour phone number is {Phone}\nYour mail ID is {Mail}\nYour date of birth is {DOB.ToString("dd/MM/yyyy")}\nYour gender is {Gender}");
        }
    }
}