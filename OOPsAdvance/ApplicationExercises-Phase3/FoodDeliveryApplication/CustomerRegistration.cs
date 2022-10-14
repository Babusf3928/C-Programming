using System;

namespace FoodDeliveryApplication
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private static int s_customerId = 1000;
        public string CustomerID { get; }

        public double WalletBalance { get; set; }

        public CustomerRegistration(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mail,string location):base(name,fatherName,gender,mobile,dob,mail,location)
        {
            s_customerId++;
            CustomerID="CID"+s_customerId;
        }

        public CustomerRegistration(string data)
        {
            string [] values = data.Split(",");
            s_customerId = int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            WalletBalance = double.Parse(values[1]);
            Name = values[2];
            FatherName = values[3];
            Gender = Enum.Parse<Gender>(values[4],true);
            Mobile = long.Parse(values[5]);
            DOB = DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
            Mail = values[7];
            Location = values[8];
        }

        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to recharge : ");
            double amount = double.Parse(Console.ReadLine());
            WalletBalance += amount;
            System.Console.WriteLine("Wallet Recharge Successful ");
        }
    }
}