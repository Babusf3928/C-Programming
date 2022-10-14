using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Shop"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Shop");
            }
            if(!File.Exists("Shop/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Shop/CustomerDetails.csv");
            }
            if(!File.Exists("Shop/ProductDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Shop/ProductDetails.csv");
            }
            if(!File.Exists("Shop/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Shop/OrderDetails.csv");
            }
        }

        public static void ReadLine()
        {
            string [] customers = File.ReadAllLines("Shop/CustomerDetails.csv");

            foreach(string data in customers)
            {
                CustomerDetails customer = new CustomerDetails(data);
                Operations.customerList.Add(customer);
            }

            string [] products = File.ReadAllLines("Shop/ProductDetails.csv");

            foreach(string data in products)
            {
                ProductDetails product = new ProductDetails(data);
                Operations.productList.Add(product);
            }

            string [] orders = File.ReadAllLines("Shop/OrderDetails.csv");

            foreach(string data in orders)
            {
                OrderDetails order = new OrderDetails(data);
                Operations.orderList.Add(order);
            }
        }

        public static void WriteToFiles()
        {
            string [] customerDetails = new string[Operations.customerList.Count];
            for(int i = 0;i<Operations.customerList.Count;i++)
            {
                customerDetails[i]=Operations.customerList[i].CustomerID+","+Operations.customerList[i].CustomerName+","+Operations.customerList[i].City+","+Operations.customerList[i].MobileNumber+","+Operations.customerList[i].WalletBalance+","+Operations.customerList[i].Mail;
            }
            File.WriteAllLines("Shop/CustomerDetails.csv",customerDetails);
        }
        
    }
}