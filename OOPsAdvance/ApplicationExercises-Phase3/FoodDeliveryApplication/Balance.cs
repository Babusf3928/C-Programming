using System;


namespace FoodDeliveryApplication
{
    public interface IBalance
    {
        double WalletBalance { get; set; }

        void WalletRecharge();
        
    }
}