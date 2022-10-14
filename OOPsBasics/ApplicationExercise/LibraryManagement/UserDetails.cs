using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public enum Gender{Default,Male,Female}
    
    public enum Department{Default,ECE,EEE,CSE}
    public class UserDetails
    {
        private static int s_registrationId=3000;
        public string RegistrationID { get;}
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }

        public double WalletBalance { get; set; }

        public UserDetails(string userName,Gender gender,Department department,long phone,string mail,double walletBalance)
        {
            s_registrationId++;
            RegistrationID="SF"+s_registrationId;
            UserName=userName;
            Gender=gender;
            Department=department;
            Phone=phone;
            Mail=mail;
            WalletBalance=walletBalance;
        }


    }
}