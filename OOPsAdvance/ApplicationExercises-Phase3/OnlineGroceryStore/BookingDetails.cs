using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId = 3000;
        public string BookingID { get; set; }
        public string CustomerId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerId,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingID="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string data)
        {
            string [] values = data.Split(",");
            s_bookingId = int.Parse(values[0].Remove(0,3));
            BookingID= values[0];
            CustomerId= values[1];
            TotalPrice= double.Parse(values[2]);
            DateOfBooking= DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(values[4],true);
        }

        public void ShowBooking()
        {
            System.Console.WriteLine($"Booking ID is {BookingID}\nCustomer ID is {CustomerId}\nTotal Price is {TotalPrice}\nDate Of Booking is {DateOfBooking.ToString("dd/MM/yyyy")}\nBooking Status is {BookingStatus}");
        }
    }
}