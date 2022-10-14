using System;


namespace FoodDeliveryApplication
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderID { get; set; }
        public string BookingId { get; set; }
        public string FoodId { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingId,string foodId,int purchaseCount,double priceOfOrder)
        {
            s_orderId++;
            OrderID="OID"+s_orderId;
            BookingId=bookingId;
            FoodId=foodId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }

        public OrderDetails(string data)
        {
            string [] values = data.Split(",");
            s_orderId = int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            BookingId=values[1];
            FoodId=values[2];
            PurchaseCount= int.Parse(values[3]);
            PriceOfOrder= double.Parse(values[4]);
        }
    }
}