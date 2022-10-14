using System;

namespace AccountLibrary
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum AccountType{Default,SB,FD,RD}
    public class AccountDetails
    {
        public string Name { get; set; } //AutoProperty
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public AccountType AccountType { get; set; }
        public double Balance { get; set; }

        public AccountDetails(string name,string fathername,Gender gender,DateTime dob,AccountType accountType)
        {
            Name=name;
            FatherName=fathername;
            Gender=gender;
            DOB=dob;
            AccountType=accountType;
        }

        public void Deposit()
        {
            System.Console.WriteLine("Enter the amount to deposit : ");
            double deposit = double.Parse(Console.ReadLine());
            Balance=Balance+deposit;
            System.Console.WriteLine("Your account balance is "+Balance);
        }
        public void Withdraw()
        {
            System.Console.WriteLine("Enter the withdraw amount : ");
            double withdraw = double.Parse(Console.ReadLine());
            Balance = Balance - withdraw;
            System.Console.WriteLine("You have withdrawed : "+withdraw);
            System.Console.WriteLine("Your Remaining balance : "+Balance);
        }

        //Destractor:
        // ~StudentDetails()
        //{

        //}

    }
}