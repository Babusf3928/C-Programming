using System;
using System.IO;

namespace FoodDeliveryApplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Hotel"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Hotel");
            }

            if(!File.Exists("Hotel/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Hotel/CustomerDetails.csv");
            }

            if(!File.Exists("Hotel/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Hotel/FoodDetails.csv");
            }

            if(!File.Exists("Hotel/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Hotel/BookingDetails.csv");
            }

            if(!File.Exists("Hotel/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Hotel/OrderDetails.csv");
            }
        }

        public static void ReadFiles()
        {
            string [] customers = File.ReadAllLines("Hotel/CustomerDetails.csv");
            foreach(string data in customers )
            {
                CustomerRegistration customer = new CustomerRegistration(data);
                Operations.customerList.Add(customer);
            }

            string [] foods = File.ReadAllLines("Hotel/FoodDetails.csv");
            foreach(string data in foods )
            {
                FoodDetails food = new FoodDetails(data);
                Operations.foodList.Add(food);
            }

            string [] bookings = File.ReadAllLines("Hotel/BookingDetails.csv");
            foreach(string data in bookings )
            {
                BookingDetails booking = new BookingDetails(data);
                Operations.bookingList.Add(booking);
            }

            string [] orders = File.ReadAllLines("Hotel/OrderDetails.csv");
            foreach(string data in orders )
            {
                OrderDetails order = new OrderDetails(data);
                Operations.orderList.Add(order);
            }
        }

        public static void WriteToFiles()
        {
            string [] customerDetails = new string [Operations.customerList.Count];
            for(int i = 0;i<Operations.customerList.Count;i++)
            {
                customerDetails[i] = Operations.customerList[i].CustomerID+","+Operations.customerList[i].WalletBalance+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].Mobile+","+Operations.customerList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.customerList[i].Mail+","+Operations.customerList[i].Location;
            }
            File.WriteAllLines("Hotel/CustomerDetails.csv",customerDetails);

            string [] foodDetails = new string [Operations.foodList.Count];
            for(int i = 0;i<Operations.foodList.Count;i++)
            {
                foodDetails[i] = Operations.foodList[i].FoodID+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].PricePerQuantity;
            }
            File.WriteAllLines("Hotel/FoodDetails.csv",foodDetails);

            string [] bookingDetails = new string [Operations.bookingList.Count];
            for(int i = 0;i<Operations.bookingList.Count;i++)
            {
                bookingDetails[i] = Operations.bookingList[i].BookingID+","+Operations.bookingList[i].CustomerId+","+Operations.bookingList[i].TotalPrice+","+Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("Hotel/BookingDetails.csv",bookingDetails);

            string [] orderDetails = new string [Operations.orderList.Count];
            for(int i = 0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i] = Operations.orderList[i].OrderID+","+Operations.orderList[i].BookingId+","+Operations.orderList[i].FoodId+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("Hotel/OrderDetails.csv",orderDetails);
        }
    }
}