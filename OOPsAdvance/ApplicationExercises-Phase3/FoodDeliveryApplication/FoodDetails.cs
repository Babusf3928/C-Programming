using System;


namespace FoodDeliveryApplication
{
    public class FoodDetails
    {
        private static int s_foodId=100;
        public string FoodID { get; }
        public string FoodName { get; set; }
        public double PricePerQuantity { get; set; }

        public FoodDetails(string foodName,double pricePerQuantity)
        {
            s_foodId++;
            FoodID="FID"+s_foodId;
            FoodName=foodName;
            PricePerQuantity=pricePerQuantity;
        }

        public FoodDetails(string data)
        {
            string [] values = data.Split(",");
            s_foodId = int.Parse(values[0].Remove(0,3));
            FoodID= values[0];
            FoodName= values[1];
            PricePerQuantity= double.Parse(values[2]);
        }
    }
}