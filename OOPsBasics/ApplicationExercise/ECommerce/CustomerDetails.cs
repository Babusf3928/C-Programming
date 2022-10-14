using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class CustomerDetails
    {
        public static int s_customerID=1000;
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long MobileNumber { get; set; }
        public double WalletBalance { get; set; }
        public string Mail { get; set; }

        public CustomerDetails(string customerName,string city,long mobileNumber,double walletBalance,string mail)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            CustomerName=customerName;
            City=city;
            MobileNumber=mobileNumber;
            WalletBalance=walletBalance;
            Mail=mail;

        }

        public CustomerDetails(string data)
        {
            string [] values = data.Split(',');
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            CustomerName=values[1];
            City=values[2];
            MobileNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);
            Mail=values[5];

        }
    }
}