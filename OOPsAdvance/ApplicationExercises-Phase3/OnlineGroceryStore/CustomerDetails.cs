using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private static int s_customerId = 1000;
        public string CustomerID { get; set; }
        public double WalletBalance { get; set; }

        public CustomerDetails(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mail,double walletBalance):base(name,fatherName,gender,mobileNumber,dob,mail)
        {
            s_customerId++;
            CustomerID="CID"+s_customerId;
           
            
        }

        public CustomerDetails(string data)
        {
            string [] values = data.Split(",");
            s_customerId = int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            Name = values[1];
            FatherName = values[2];
            Gender = Enum.Parse<Gender>(values[3],true);
            MobileNumber = long.Parse(values[4]);
            DOB = DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            Mail = values[6];
            WalletBalance=double.Parse(values[7]);
            
        }

        public void ShowCustomer()
        {
            System.Console.WriteLine($"Your Customer ID is {CustomerID}\nYour WalletBalance is {WalletBalance}\nYour name is {Name}\nYour father name is {FatherName}\nYour gender is {Gender}\nYour mobile number is {MobileNumber}\nYour date of birth is {DOB.ToString("dd/MM/yyyy")}\nYour mail ID is {Mail} ");
        }

        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to recharge : ");
            double amount = double.Parse(Console.ReadLine());
            WalletBalance+=amount;
            System.Console.WriteLine("Recharge Successful");
        }
    }
}