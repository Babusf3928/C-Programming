using System;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// It is the class that has the screening information of the theatre
    /// </summary>
    public class ScreeningDetails
    {
        /// <summary>
        /// It is the property that refers to movie id of the movie
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }
        /// <summary>
        /// It is the property that refers to theatre id  of the theatre
        /// </summary>
        /// <value></value>
        public string TheatreId { get; set; }
        /// <summary>
        /// It is the property that refers to available seats in the theatre
        /// </summary>
        /// <value></value>
        public int AvailableSeats { get; set; }
        /// <summary>
        /// It is the property that refers to ticket price of the theatre
        /// </summary>
        /// <value></value>
        public double TicketPrice { get; set; }
        /// <summary>
        /// It is the parameterised constructor is used to assign the properties to the variable where the details are stored
        /// </summary>
        /// <param name="movieId"></param>It is the variable assigned to the movie id property
        /// <param name="theatreId"></param>It is the variable assigned to the theatre id property
        /// <param name="availableSeats"></param>It is the variable assigned to the available seats property
        /// <param name="ticketPrice"></param>It is the variable assigned to the ticket price property

        public ScreeningDetails(string movieId,string theatreId,int availableSeats,double ticketPrice)
        {
            MovieId=movieId;
            TheatreId=theatreId;
            AvailableSeats=availableSeats;
            TicketPrice=ticketPrice;
        }

        public ScreeningDetails(string data)
        {
            string [] values = data.Split(",");
            MovieId=values[0];
            TheatreId=values[1];
            AvailableSeats=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }
    }
}