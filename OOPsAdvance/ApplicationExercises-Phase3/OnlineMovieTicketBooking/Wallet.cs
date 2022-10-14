using System;


namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// It is the interface which consists of only the name of the method or property but no definition in it
    /// </summary>
    public interface IWallet
    {
        /// <summary>
        /// It is the property of the wallet balance of the user without any access specifiers and definition
        /// </summary>
        /// <value></value>
        double WalletBalance { get; set; }
        /// <summary>
        /// It is the abstract method which does not contains definition
        /// </summary>
        /// <param name="amount"></param>It is the argument that is passed in this method
        /// <returns></returns>
        double RechargeWallet(double amount);
    }
}