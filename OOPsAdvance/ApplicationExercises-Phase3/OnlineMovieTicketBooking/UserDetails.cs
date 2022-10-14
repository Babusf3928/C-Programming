using System;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// It is the class that have inherit the datas from class Personal details and an interface Wallet
    /// </summary>
    public class UserDetails:PersonalDetails, IWallet
    {
        /// <summary>
        /// It is a private field that has initial value of user id for increment
        /// </summary>
        private static int s_userId = 1000;
        /// <summary>
        /// It is the property that refers to the user id of the user
        /// </summary>
        /// <value></value>
        public string UserID { get;  }
        /// <summary>
        /// It is the property that refers to the wallet balance of the user
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }
        /// <summary>
        /// It is the parameterised constructor is used to assign the properties to the variable where the details are stored
        /// </summary>
        /// <param name="name"></param>It is the variable assigned to the name property
        /// <param name="age"></param>It is the variable assigned to the age property
        /// <param name="phoneNumber"></param>It is the variable assigned to the phone number property
        /// <param name="walletBalance"></param>It is the variable assigned to the walletbalance property
        /// <returns></returns>
        public UserDetails(string name,int age,long phoneNumber,double walletBalance):base(name,age,phoneNumber)
        {
            s_userId++;
            UserID = "UID"+s_userId;
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
            WalletBalance=walletBalance;
        }

        public UserDetails(string data)
        {
            string [] values = data.Split(",");
            s_userId = int.Parse(values[0].Remove(0,3));
            UserID = values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            PhoneNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);
        }
        public double RechargeWallet(double amount)
        {
            WalletBalance = WalletBalance+amount;
            return WalletBalance;
        }
    }
}