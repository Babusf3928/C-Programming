using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public static class Operations
    {
        static AccountDetails currentAccountant = null;
        static List<AccountDetails> accountList = new List<AccountDetails>();
        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice = "no";
                        break;
                    }
                }
            }while(choice =="yes");
        }

        public static void Registration()
        {
            System.Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your father name : ");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your gender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your date of birth in dd/MM/yyyy");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter the Account type that you want to open : ");
            AccountType accountType =Enum.Parse<AccountType>(Console.ReadLine(),true);
            
            AccountDetails account = new AccountDetails(name,fatherName,gender,dob,accountType);
            accountList.Add(account);
        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your user name :");
            string username = Console.ReadLine();
            foreach(AccountDetails account in accountList)
            {
                if(account.Name ==username)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentAccountant=account;
                    SubMenu();
                }
                else
                {
                    System.Console.WriteLine("Wrong name");
                }
            }
        }

        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Show Details 2.Deposit 3.Withdraw 4.Balance 5.Exit Submenu");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Details");
                        currentAccountant.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Deposit");
                        currentAccountant.Deposit();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Withdraw");
                        currentAccountant.Withdraw();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Balance");
                        currentAccountant.RemainingBalance();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit Submenu");
                        choice ="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
    }
}