using System;
using System.Collections.Generic;
namespace BankAccount
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum AccountType{Default,SB,FD,RD}
    class Program
    {
        public static void Main(string[] args)
        {
            Operations.MainMenu();
        }
    }
}