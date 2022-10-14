using System;
using System.Collections.Generic;
using AccountLibrary;
namespace AccountApplication
{
    
    public class Operations
    {
        public static void MainMenu()
        {
            List<AccountDetails> accountList = new List<AccountDetails>();
            string willing = "";

            do
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

                System.Console.WriteLine("Do you want create an account ?");
                willing = Console.ReadLine().ToLower();

            }while(willing=="yes");

            foreach(AccountDetails accountant in accountList)
            {
                System.Console.WriteLine("\nAccount Created");
                System.Console.WriteLine("Details of Accountant:\n");
                System.Console.WriteLine($"Name is {accountant.Name}\nFather name is {accountant.FatherName} \nGender is {accountant.Gender} \nDate of birth is {accountant.DOB.ToString("dd/MM/yyyy")}\nAccount type is {accountant.AccountType}");
                accountant.Deposit();
                accountant.Withdraw();
            }
        }
    }
}