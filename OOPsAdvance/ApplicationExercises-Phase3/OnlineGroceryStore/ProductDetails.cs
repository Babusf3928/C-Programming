using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class ProductDetails
    {
        private static int s_productId = 100;
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int AvailableQuantity { get; set; }
        public double PricePerQuantity { get; set; }

        public ProductDetails(string productName,int availableQuantity,double pricePerQuantity)
        {
            s_productId++;
            ProductID="PID"+s_productId;
            ProductName=productName;
            AvailableQuantity=availableQuantity;
            PricePerQuantity=pricePerQuantity;
        }

        public ProductDetails(string data)
        {
            string [] values = data.Split(",");
            s_productId = int.Parse(values[0].Remove(0,3));
            ProductID=values[0];
            ProductName=values[1];
            AvailableQuantity=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);
        }

        public void ShowProduct()
        {
            System.Console.WriteLine($"ProductId is {ProductID}\nProductName is {ProductName}\nAvailable Quantity is {AvailableQuantity} \nPrice per Quantity is {PricePerQuantity}");
        }
        
    }
}