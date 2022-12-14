using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public enum Gender{Default,Male,Female}
    public class BeneficiaryDetails
    {
        private static int s_registrationNumber=1000;
        public string  RegistrationNumber { get;}
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public BeneficiaryDetails(string name,Gender gender,long mobileNumber,string city,int age)
        {
            s_registrationNumber++;
            RegistrationNumber="BID"+s_registrationNumber;
            Name=name;
            Gender=gender;
            MobileNumber=mobileNumber;
            City=city;
            Age=age;
        }
    }
}