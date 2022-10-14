using System;

namespace OnlineMovieTicketBooking
{
    public delegate void EventManager();
    public class Operations
    {
        public static event EventManager eventLink = null; 

        public static void Subscribe()
        {
            eventLink += new EventManager(Files.Create);

            eventLink += new EventManager(Files.ReadFiles);

            eventLink += new EventManager(Operations.MainMenu);

            eventLink += new EventManager(Files.WriteToFiles);
        }

        public static void StartEvent()
        {
            Subscribe();
            eventLink();
        }
        static UserDetails currentUser;
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<MovieDetails> movieList = new List<MovieDetails>();

        public static List<TheatreDetails> theatreList = new List<TheatreDetails>();

        public static List<ScreeningDetails> screeningList = new List<ScreeningDetails>();

        public static List<BookingDetails> bookingList = new List<BookingDetails>();

        
        public static void MainMenu() //It is the method that consists of main menu
        {
            
            string choice = "yes";
            do
            {
                
                System.Console.WriteLine("Select Option\n1.User Registration\n2.Login and Purchase\n3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        LoginAndPurchase();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exiting MainMenu");
                        choice="no";
                        break;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid Option");
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void UserRegistration()   //Method used for registering a new user
        {
            System.Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your age :");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter phone number :");
            long phoneNumber = long.Parse(Console.ReadLine());

            UserDetails newUser = new UserDetails(name,age,phoneNumber,0);
            userList.Add(newUser);

            System.Console.WriteLine("Your User Registration ID is "+newUser.UserID);
        }

        public static void LoginAndPurchase()   //Method used for login of the existing user
        {
            System.Console.WriteLine("Enter the User Id : ");
            string userId = Console.ReadLine();
            
            int flag = 0;
            foreach(UserDetails user in userList)
            {
                if(user.UserID==userId)
                {
                    flag++;
                    currentUser=user;
                    System.Console.WriteLine("Login Successfully");
                    SubMenu();
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Invalid User Id");
            }

        }

        public static void SubMenu()        //Method consists of the Sub menus
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option \na.Ticket Booking \nb.Ticket Cancellation \nc.Booking History \nd.Wallet Recharge \ne.Exit SubMenu");
                char option = char.Parse(Console.ReadLine());
                switch(option)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Ticket Booking");
                        TicketBooking();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Ticket Cancellation");
                        TicketCancellation();
                        break;
                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Booking History");
                        BookingHistory();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Wallet Recharge");
                        WalletRecharge();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Exiting SubMenu");
                        System.Console.WriteLine("Returning to MainMenu");
                        choice = "no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void TicketBooking()      //Method used for the booking of the ticket
        {
            //Show the Theatre list
            foreach(TheatreDetails theatres in theatreList)
            {
                System.Console.WriteLine($"Theatre ID is {theatres.TheatreId}\t Theatre name is {theatres.TheatreName}\t Theatre location is {theatres.TheatreLocation}");
            }

            //Ask user to select theatre with id

            System.Console.WriteLine("Enter the Theatre ID that you want to book :");
            string theatreId = Console.ReadLine().ToUpper();
            int flag =0;
            foreach(ScreeningDetails screens in screeningList)
            {
                if(theatreId==screens.TheatreId)
                {
                    flag++;
                    foreach(MovieDetails movies in movieList)
                    {
                        if(screens.MovieId==movies.MovieID)
                        {
                            System.Console.WriteLine($"Movie ID is {movies.MovieID}\t Movie Name is {movies.MovieName}\t Language of the movie is {movies.Language} ");
                        }
                    }
                    
                }         
            }
            if(flag==0)
            {
                System.Console.WriteLine("Invalid Theatre ID");
            } 

            System.Console.WriteLine("Enter the Movie ID that you want to book : ");
            string movieId = Console.ReadLine();

            int avail = 0;
           
            
                    foreach(MovieDetails movie in movieList)
                    {    
                        if(movie.MovieID==movieId )
                        {
                            avail++;
                            System.Console.WriteLine("Enter the count of seats that you want to book : ");
                            int count = int.Parse(Console.ReadLine());
                            foreach(ScreeningDetails screens in screeningList)
                            {
                                if(screens.AvailableSeats>=count)
                            {
                                double totalPrice = count*screens.TicketPrice;
                                totalPrice= totalPrice + (0.18*totalPrice);

                                if(currentUser.WalletBalance>=totalPrice)
                                {
                                    currentUser.WalletBalance-=totalPrice;
                                    screens.AvailableSeats-=count;

                                    BookingDetails newBooking = new BookingDetails(currentUser.UserID,movie.MovieID,screens.TheatreId,count,totalPrice,BookingStatus.Booked);
                                    bookingList.Add(newBooking);
                                    System.Console.WriteLine("Ticket Booked Successfully");
                                    break;
                                }
                                else
                                {
                                    System.Console.WriteLine("Insufficient Balance.Please Recharge the wallet");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine($"Required seat count is not available . Current availability is {screens.AvailableSeats}");
                            }
                            }
                            
                        }    
                    
                    }

                    if(avail ==0)
                    {
                        System.Console.WriteLine("No movies are there in this Id");
                    }    
                       
        }    

        public static void TicketCancellation()     //Method used for cancelling the ticket
        {
            foreach(BookingDetails bookings in bookingList)
            {
                if(currentUser.UserID==bookings.UserId)
                {
                    System.Console.WriteLine($"Booking ID is {bookings.BookingID} \tUser ID is {bookings.UserId} \tMovie ID is {bookings.MovieId} \tTheatre ID is {bookings.TheatreId} \tSeat Count is {bookings.SeatCount} \tTotal amount is {bookings.TotalAmount} \tBooking status is {bookings.BookingStatus}");
                }
            }
            System.Console.WriteLine("Enter the booking ID to cancel : ");
            string bookingId = Console.ReadLine();
            
            int flag = 0;
            foreach(BookingDetails booking in bookingList)
            {
                if(bookingId==booking.BookingID && booking.BookingStatus==BookingStatus.Booked)
                {
                   flag++;
                   foreach(ScreeningDetails screening in screeningList)
                   {
                        if(booking.TheatreId==screening.TheatreId)
                        {
                            screening.AvailableSeats+=booking.SeatCount;
                            currentUser.WalletBalance+=(booking.TotalAmount-20);
                            booking.BookingStatus=BookingStatus.Cancelled;
                            System.Console.WriteLine("Ticket Cancelled Successfully");
                            break;
                        }
                   } 
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("No tickets are booked in this Id");
            }
        }

        public static void BookingHistory()     //Method used for show booking history of the logged in user
        {
            foreach(BookingDetails bookings in bookingList)
            {
                if(currentUser.UserID==bookings.UserId)
                {
                    System.Console.WriteLine($"Booking ID is {bookings.BookingID} \tUser ID is {bookings.UserId} \tMovie ID is {bookings.MovieId} \tTheatre ID is {bookings.TheatreId} \tSeat Count is {bookings.SeatCount} \tTotal amount is {bookings.TotalAmount} \tBooking status is {bookings.BookingStatus}");
                }
            }

            
        }

        public static void WalletRecharge()         //Method used to recharge the wallet
        {
            System.Console.WriteLine("Enter the amount to recharge : ");
            double amount = double.Parse(Console.ReadLine());
            currentUser.RechargeWallet(amount);
            System.Console.WriteLine("Wallet Recharged Successfully ");
        }
        public static void AddDefaultData()         //Default data method
        {
            //user data
            UserDetails user1 = new UserDetails("Ravichandran",30,8599488003,1000);
            UserDetails user2 = new UserDetails("Baskaran",30,9857747327,2000);
            userList.Add(user1);
            userList.Add(user2);


            //theatre data
            TheatreDetails theatre1 = new TheatreDetails("Inox","Anna Nagar");
            TheatreDetails theatre2 = new TheatreDetails("Ega Theatre","Chetpet");
            TheatreDetails theatre3 = new TheatreDetails("Kamala","Vadapalani");
            theatreList.Add(theatre1);
            theatreList.Add(theatre2);
            theatreList.Add(theatre3);

            //Movie data
            MovieDetails movie1 = new MovieDetails("Bagubali 2","Telugu");
            MovieDetails movie2 = new MovieDetails("Ponniyin Selvan","Tamil");
            MovieDetails movie3 = new MovieDetails("Cobra","Tamil");
            MovieDetails movie4 = new MovieDetails("Vikram","Hindi (Dubbed)");
            MovieDetails movie5 = new MovieDetails("Vikram","Tamil");
            MovieDetails movie6 = new MovieDetails("Beast","English");
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);

            //Screening data
            ScreeningDetails screen1 = new ScreeningDetails("MID501","TID301",5,200);
            ScreeningDetails screen2 = new ScreeningDetails("MID502","TID301",2,300);
            ScreeningDetails screen3 = new ScreeningDetails("MID506","TID301",1,50);
            ScreeningDetails screen4 = new ScreeningDetails("MID501","TID302",11,400);
            ScreeningDetails screen5 = new ScreeningDetails("MID502","TID302",20,300);
            ScreeningDetails screen6 = new ScreeningDetails("MID504","TID302",2,500);
            ScreeningDetails screen7 = new ScreeningDetails("MID505","TID303",11,100);
            ScreeningDetails screen8 = new ScreeningDetails("MID502","TID303",20,200);
            ScreeningDetails screen9 = new ScreeningDetails("MID504","TID303",2,350);
            screeningList.Add(screen1);
            screeningList.Add(screen2);
            screeningList.Add(screen3);
            screeningList.Add(screen4);
            screeningList.Add(screen5);
            screeningList.Add(screen6);
            screeningList.Add(screen7);
            screeningList.Add(screen8);
            screeningList.Add(screen9);

            //Booking data
            BookingDetails booking1 = new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("UID1001","MID504","TID302",1,400,BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("UID1002","MID505","TID302",1,300,BookingStatus.Booked);
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);
        
        }


    }
}