using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalEmployment
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetails
    {
        private static int s_aadharId=1000;
        public string AadharID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long phone)
        {
            s_aadharId++;
            AadharID="AID"+s_aadharId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
        }

        public PersonalDetails(string aadhar,string name,string fatherName,Gender gender,long phone)
        {
            AadharID=aadhar;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
        }

        public void ShowDetails()
        {
            
            System.Console.WriteLine($"Your Aadhar ID is {AadharID} \nYour Name is {Name}\nYour Father Name is {FatherName}\nYour gender is {Gender}\nYour phone number is {Phone}");
            
        }
    }
}