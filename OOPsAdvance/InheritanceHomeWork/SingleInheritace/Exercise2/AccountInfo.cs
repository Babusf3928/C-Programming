using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class AccountInfo:PersonalInfo
    {
        private static int s_accountNumber=1000;
        public string AccountNumber { get;  }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        public AccountInfo(string name,string fatherName,long phone,string mail,DateTime dob,Gender gender,string branchName,string ifscCode,double balance):base(name,fatherName,phone,mail,dob,gender)
        {
            s_accountNumber++;
            AccountNumber="AIN"+s_accountNumber;
            BranchName=branchName;
            IFSCCode=ifscCode;
            Balance=balance;
        }

        public void AccountDetails()
        {
            ShowDetails();
            System.Console.WriteLine($"Your Account number is {AccountNumber}\nYour branch name is {BranchName}\nYour IFSC code is {IFSCCode}");
        }
    }
}