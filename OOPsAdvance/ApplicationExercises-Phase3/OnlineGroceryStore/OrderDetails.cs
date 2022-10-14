using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class OrderDetails
    {
        private static int s_orderId = 100;
        public string  OrderID { get; }
        public string BookingId { get; set; }
        public string ProductId { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingId,string productId,int purchaseCount,double priceOfOrder )
        {
            s_orderId++;
            OrderID="OID"+s_orderId;
            BookingId=bookingId;
            ProductId=productId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }

        public OrderDetails(string data )
        {
            string [] values = data.Split(",");
            s_orderId = int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            BookingId=values[1];
            ProductId=values[2];
            PurchaseCount= int.Parse(values[3]);
            PriceOfOrder= double.Parse(values[4]);
        }


        public void ShowOrder()
        {
            System.Console.WriteLine($"Order ID is {OrderID}\nBooking ID is {BookingId}\nProduct ID is {ProductId}\nPurchase Count is {PurchaseCount}\nPrice Of Order is {PriceOfOrder}");
        }
    }
}