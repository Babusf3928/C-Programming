using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
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
            System.Console.WriteLine("Your amount has been deposited in your account");
        }
        public void Withdraw()
        {
            System.Console.WriteLine("Enter the withdraw amount : ");
            double withdraw = double.Parse(Console.ReadLine());
            Balance = Balance - withdraw;
            System.Console.WriteLine("You have withdrawed : "+withdraw);
            
        }

        public void RemainingBalance()
        {
            System.Console.WriteLine("Your Remaining balance : "+Balance);
        }

        public void ShowDetails()
        {
            System.Console.WriteLine("Details of Accountant:\n");
            System.Console.WriteLine($"Name is {Name}\nFather name is {FatherName} \nGender is {Gender} \nDate of birth is {DOB.ToString("dd/MM/yyyy")}\nAccount type is {AccountType}");
        }

        //Destractor:
        // ~StudentDetails()
        //{

        //}

    }
}