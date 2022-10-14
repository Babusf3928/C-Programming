using System;


namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// Booking status enum is a datatype which is used in this for booking status
    /// </summary>
    public enum BookingStatus{Default,Booked,Cancelled}
    
    
    /// <summary>
    /// Booking details class is the class that consists of fields and properties .
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// It is a private field that has initial value of booking id 
        /// </summary>
        /// <value></value>
        private static int s_bookingId=7000;

        /// <summary>
        /// Property that refers to the booking id which cannot be set by the user.
        /// </summary>
        /// <value></value>
        public string BookingID { get; }
        /// <summary>
        /// Property that refers to the user id of the user
        /// </summary>
        /// <value></value>
        public string UserId { get; set; }

        /// <summary>
        /// It is the property that consists of id of the movie
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }

        /// <summary>
        /// It is the property that consists of id of the theatre
        /// </summary>
        /// <value></value>
        public string TheatreId { get; set; }

        /// <summary>
        /// It is the property that consists of number ofseat counts that the user booked
        /// </summary>
        /// <value></value>
        public int SeatCount { get; set; }
        /// <summary>
        /// It is the property that consists of the Total amount of the tickets that the user booked
        /// </summary>
        /// <value></value>
        public double TotalAmount { get; set; }
        /// <summary>
        /// It is the property that consists of the booking status of the ticket booking
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus { get; set; }
        /// <summary>
        /// The parameterised constructor is used to assign the properties to the variable where the details are stored
        /// </summary>
        /// <param name="userId"></param> It is variable assigned to the User id property
        /// <param name="movieId"></param>It is variable assigned to the movie id property
        /// <param name="theatreId"></param>It is variable assigned to the theatre id property
        /// <param name="seatCount"></param>It is variable assigned to the  seat count property
        /// <param name="totalAmount"></param>It is variable assigned to the total amount property
        /// <param name="bookingStatus"></param>It is variable assigned to the booking status property
        public BookingDetails(string userId,string movieId,string theatreId,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingID="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theatreId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string data)
        {
            string [] values = data.Split(",");
            s_bookingId = int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            UserId=values[1];
            MovieId=values[2];
            TheatreId=values[3];
            SeatCount= int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus=Enum.Parse<BookingStatus>(values[6],true);
        }
    }
}