using System;
using System.IO;

namespace OnlineMovieTicketBooking
{
    public class Files
    {
        public static void Create()         //Method used to create the folder and files
        {
            if(!Directory.Exists("TicketCounter"))
            {
                System.Console.WriteLine("Creating folder");
                Directory.CreateDirectory("TicketCounter");
            }
            if(!File.Exists("TicketCounter/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("TicketCounter/UserDetails.csv");
            }
            if(!File.Exists("TicketCounter/TheatreDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("TicketCounter/TheatreDetails.csv");
            }
            if(!File.Exists("TicketCounter/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("TicketCounter/ScreeningDetails.csv");
            }
            if(!File.Exists("TicketCounter/MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("TicketCounter/MovieDetails.csv");
            }
            if(!File.Exists("TicketCounter/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("TicketCounter/BookingDetails.csv");
            }
        }

        public static void ReadFiles()      //Method used to read the files
        {
            string [] userDetails = File.ReadAllLines("TicketCounter/UserDetails.csv");
            foreach(string data in userDetails)
            {
                UserDetails user = new UserDetails(data);
                Operations.userList.Add(user);
            }
            string [] theatreDetails = File.ReadAllLines("TicketCounter/TheatreDetails.csv");
            foreach(string data in theatreDetails)
            {
                TheatreDetails theatre = new TheatreDetails(data);
                Operations.theatreList.Add(theatre);
            }
            string [] screeningDetails = File.ReadAllLines("TicketCounter/ScreeningDetails.csv");
            foreach(string data in screeningDetails)
            {
                ScreeningDetails screen = new ScreeningDetails(data);
                Operations.screeningList.Add(screen);
            }
            string [] movieDetails = File.ReadAllLines("TicketCounter/MovieDetails.csv");
            foreach(string data in movieDetails)
            {
                MovieDetails movie = new MovieDetails(data);
                Operations.movieList.Add(movie);
            }
            string [] bookingDetails = File.ReadAllLines("TicketCounter/BookingDetails.csv");
            foreach(string data in bookingDetails)
            {
                BookingDetails booking = new BookingDetails(data);
                Operations.bookingList.Add(booking);
            }
        }

        
        public static void WriteToFiles()   //Method used to write on the file
        {
            string [] userDetails = new string[Operations.userList.Count];
            for(int i =0;i<Operations.userList.Count;i++)
            {
                userDetails[i] = Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("TicketCounter/UserDetails.csv",userDetails);

            string [] theatreDetails = new string[Operations.theatreList.Count];
            for(int i = 0;i<Operations.theatreList.Count;i++)
            {
                theatreDetails[i] = Operations.theatreList[i].TheatreId+","+Operations.theatreList[i].TheatreName+","+Operations.theatreList[i].TheatreLocation;
            }
            File.WriteAllLines("TicketCounter/TheatreDetails.csv",theatreDetails);

            string [] screeningDetails = new string[Operations.screeningList.Count];
            for(int i =0;i<Operations.screeningList.Count;i++)
            {
                screeningDetails[i] = Operations.screeningList[i].MovieId+","+Operations.screeningList[i].TheatreId+","+Operations.screeningList[i].AvailableSeats+","+Operations.screeningList[i].TicketPrice;
            }
            File.WriteAllLines("TicketCounter/ScreeningDetails.csv",screeningDetails);

            string [] movieDetails = new string[Operations.movieList.Count];
            for(int i =0;i<Operations.movieList.Count;i++)
            {
                movieDetails[i] = Operations.movieList[i].MovieID+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
            }
            File.WriteAllLines("TicketCounter/MovieDetails.csv",movieDetails);

            string [] bookingDetails = new string[Operations.bookingList.Count];
            for(int i =0;i<Operations.bookingList.Count;i++)
            {
                bookingDetails[i] = Operations.bookingList[i].BookingID+","+Operations.bookingList[i].UserId+","+Operations.bookingList[i].MovieId+","+Operations.bookingList[i].TheatreId+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("TicketCounter/BookingDetails.csv",bookingDetails);

        }
    }
}