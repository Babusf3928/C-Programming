using System;
using System.IO;

namespace OnlineGroceryStore
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("GroceryShop"))
            {
                System.Console.WriteLine("Creating folder");
                Directory.CreateDirectory("GroceryShop");
            }
            if(!File.Exists("GroceryShop/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("GroceryShop/CustomerDetails.csv");
            }
            if(!File.Exists("GroceryShop/ProductDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("GroceryShop/ProductDetails.csv");
            }
            if(!File.Exists("GroceryShop/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("GroceryShop/BookingDetails.csv");
            }
            if(!File.Exists("GroceryShop/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("GroceryShop/OrderDetails.csv");
            }
            
        }

        public static void ReadFiles()
        {
            string [] customers = File.ReadAllLines("GroceryShop/CustomerDetails.csv");
            foreach(string data in customers )
            {
                CustomerDetails customer = new CustomerDetails(data);
                Operation.customerList.Add(customer);
            }

            string [] products = File.ReadAllLines("GroceryShop/ProductDetails.csv");
            foreach(string data in products )
            {
                ProductDetails product = new ProductDetails(data);
                Operation.productList.Add(product);
            }

            string [] bookings = File.ReadAllLines("GroceryShop/BookingDetails.csv");
            foreach(string data in bookings )
            {
                BookingDetails booking = new BookingDetails(data);
                Operation.bookingList.Add(booking);
            }

            string [] orders = File.ReadAllLines("GroceryShop/OrderDetails.csv");
            foreach(string data in orders )
            {
                OrderDetails order = new OrderDetails(data);
                Operation.orderList.Add(order);
            }
        }

        public static void WriteToFiles()
        {
            string [] customerDetails = new string [Operation.customerList.Count];
            for(int i = 0;i<Operation.customerList.Count;i++)
            {
                customerDetails[i] = Operation.customerList[i].CustomerID+","+Operation.customerList[i].Name+","+Operation.customerList[i].FatherName+","+Operation.customerList[i].Gender+","+Operation.customerList[i].MobileNumber+","+Operation.customerList[i].DOB.ToString("dd/MM/yyyy")+","+Operation.customerList[i].Mail+","+Operation.customerList[i].WalletBalance;
            }
            File.WriteAllLines("GroceryShop/CustomerDetails.csv",customerDetails);

            string [] ProductDetails = new string [Operation.productList.Count];
            for(int i = 0;i<Operation.productList.Count;i++)
            {
                ProductDetails[i] = Operation.productList[i].ProductID+","+Operation.productList[i].ProductName+","+Operation.productList[i].AvailableQuantity+","+Operation.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("GroceryShop/ProductDetails.csv",ProductDetails);

            string [] bookingDetails = new string [Operation.bookingList.Count];
            for(int i = 0;i<Operation.bookingList.Count;i++)
            {
                bookingDetails[i] = Operation.bookingList[i].BookingID+","+Operation.bookingList[i].CustomerId+","+Operation.bookingList[i].TotalPrice+","+Operation.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Operation.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("GroceryShop/BookingDetails.csv",bookingDetails);

            string [] orderDetails = new string [Operation.orderList.Count];
            for(int i = 0;i<Operation.orderList.Count;i++)
            {
                orderDetails[i] = Operation.orderList[i].OrderID+","+Operation.orderList[i].BookingId+","+Operation.orderList[i].ProductId+","+Operation.orderList[i].PurchaseCount+","+Operation.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("GroceryShop/OrderDetails.csv",orderDetails);
        }
    }
}