using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerId=1000;
        public string CustomerID { get; }
        public double WalletBalance { get; set; }

        public CustomerDetails(string aadhar,string name,string fatherName,Gender gender,long phone):base( aadhar, name, fatherName, gender, phone)
        {
            s_customerId++;
            CustomerID="CID"+s_customerId;
        }

        public void Recharge()
        {
            System.Console.WriteLine("Enter the amount to recharge : ");
            WalletBalance += double.Parse(Console.ReadLine());
        }

        public void ShowCustomer()
        {
            System.Console.WriteLine($"Customer ID : {CustomerID}");
            ShowDetails();
            Recharge();
            System.Console.WriteLine($"Wallet Balance is : {WalletBalance}");
        }
    }
}