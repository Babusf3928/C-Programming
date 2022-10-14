using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public static class Operations
    {
        static UserDetails currentUser=null;

        static List<UserDetails> userList=new List<UserDetails>();

        static List<BookDetails> bookList=new List<BookDetails>();

        static List<BorrowDetails> borrowList=new List<BorrowDetails>();


        public static void DefaultData()
        {
            UserDetails user1 = new UserDetails("Ravichandran",Gender.Male,Department.EEE,9938388333,"ravi@gmail.com",2000);
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Priyadharshini",Gender.Female,Department.CSE,9944444455,"priya@gmail.com",2000);
            userList.Add(user2);
            BookDetails book1 = new BookDetails("C#","Author1",3);
            bookList.Add(book1);
            BookDetails book2 = new BookDetails("HTML","Author2",5);
            bookList.Add(book2);
            BookDetails book3 = new BookDetails("CSS","Author1",3);
            bookList.Add(book3);
            BookDetails book4 = new BookDetails("JS","Author1",3);
            bookList.Add(book4);
            BookDetails book5 = new BookDetails("TS","Author2",2);
            bookList.Add(book5);
            BorrowDetails borrow1 = new BorrowDetails(book1.BookID,user1.RegistrationID,new DateTime(2022,04,10),BookStatus.Issued);
            borrowList.Add(borrow1);
            BorrowDetails borrow2 = new BorrowDetails(book3.BookID,user1.RegistrationID,new DateTime(2022,04,12),BookStatus.Returned);
            borrowList.Add(borrow2);
            BorrowDetails borrow3 = new BorrowDetails(book4.BookID,user1.RegistrationID,new DateTime(2022,04,15),BookStatus.Issued);
            borrowList.Add(borrow3);
            BorrowDetails borrow4 = new BorrowDetails(book2.BookID,user2.RegistrationID,new DateTime(2022,04,11),BookStatus.Returned);
            borrowList.Add(borrow4);
            BorrowDetails borrow5 = new BorrowDetails(book5.BookID,user2.RegistrationID,new DateTime(2022,04,15),BookStatus.Issued);
            borrowList.Add(borrow5);
        }

        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option 1.User Registration 2.User Login 3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void Registration()
        {
            System.Console.WriteLine("Enter your name : ");
            string userName=Console.ReadLine();
            System.Console.WriteLine("Enter your gender :  ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your department : ");
            Department department=Enum.Parse<Department>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your phone number : ");
            long phone = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail ID : ");
            string mail = Console.ReadLine();
            System.Console.WriteLine("Enter your wallet Balance : ");
            double walletBalance = double.Parse(Console.ReadLine());
            
            UserDetails user3 = new UserDetails(userName,gender,department,phone,mail,walletBalance);
            userList.Add(user3);

            System.Console.WriteLine($"Your Registration ID is : {user3.RegistrationID}");

        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your Registration ID : ");
            string registrationID = Console.ReadLine();
            foreach(UserDetails user in userList)
            {
                if(user.RegistrationID==registrationID)
                {
                    System.Console.WriteLine("Login Successful");
                    currentUser=user;
                    SubMenu();
                }
                
            }
            
        }

        
        public static void SubMenu()
        {
            string choice ="yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Borrow Book 2.Show Borrowed History 3.Return Books 4.Exit Submenu");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Borrow Book");
                        BorrowBook();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Show Borrowed History");
                        BorrowedHistory();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Return Books");
                        ReturnBook();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }   

            }while(choice=="yes");
        }

        public static void BorrowBook()
        {
            foreach(BookDetails book in bookList)
            {
                System.Console.WriteLine($"Book ID is {book.BookID}\tBook Name is {book.BookName}\tAuthor of the book is {book.AuthorName}\tNumber of books available is {book.BookCount} ");

            }

            System.Console.WriteLine("Enter the book ID to borrow : ");
            string bookID = Console.ReadLine();
            foreach(BookDetails books in bookList)
            {
                if(books.BookID==bookID)
                {
                    if(books.BookCount >=1)
                    {
                        int count =0;
                        foreach(BorrowDetails bookBorrow in borrowList)
                        {
                            if(bookBorrow.RegistrationId==currentUser.RegistrationID && bookBorrow.Status==BookStatus.Issued)
                            {
                                 count++;
                            }
                        }
                        if(count<3)
                        {
                            BorrowDetails borrow6 = new BorrowDetails(books.BookID,currentUser.RegistrationID,DateTime.Now,BookStatus.Issued);
                            borrowList.Add(borrow6);
                            books.BookCount-=1;
                            System.Console.WriteLine("The Book Issued successfully");
                            System.Console.WriteLine($"Your borrowed ID is {borrow6.BorrowID}");
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("You have already taken 3 books");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Books are not available for the selected count.");
                        foreach(BorrowDetails borrow in borrowList)
                        {
                            if(bookID==borrow.BookId)
                            {
                                System.Console.WriteLine($"The book will be available on {borrow.BorrowedDate.AddDays(15)} ");
                            }
                        }
                    }
                }
                
            }
        }
        

        public static void BorrowedHistory()
        {
            foreach(BorrowDetails borrow in borrowList)
            {
                if(currentUser.RegistrationID==borrow.RegistrationId)
                {
                    System.Console.WriteLine($"Borrow ID is {borrow.BorrowID}\nBook ID is {borrow.BookId}\nRegistration ID is {borrow.RegistrationId}\nBorrowed date is {borrow.BorrowedDate}\nBook Status is {borrow.Status}");

                }
            }
        }

        public static void ReturnBook()
        {
            
            foreach(BorrowDetails book in borrowList)
            {
                if(currentUser.RegistrationID==book.RegistrationId)
                {
                    System.Console.WriteLine("Enter the Book ID to return : ");
                    string bookId = Console.ReadLine();
                    if(bookId==book.BookId)
                    {
                        if(book.Status==BookStatus.Issued)
                        {
                            DateTime returnDate = book.BorrowedDate.AddDays(15);
                            TimeSpan days = DateTime.Now-returnDate;
                            int numberOfDays=days.Days;
                            int fineAmount = numberOfDays*1;
                            System.Console.WriteLine($"Borrow Id is {book.BorrowID}\tBook ID is {book.BookId}\tBorrwed Date is {book.BorrowedDate}\tReturn Date is {returnDate}\nYour fine amount is {fineAmount} Rupees");
                            System.Console.WriteLine("Do you want to pay the fine and return the book? Enter 'yes' or 'no'");
                            string choice = Console.ReadLine().ToLower();
                            if(choice=="yes")
                            {
                                currentUser.WalletBalance-=fineAmount;
                                book.Status=BookStatus.Returned;
                                foreach(BookDetails returnBook in bookList)
                                {
                                    if(book.BookId==returnBook.BookID)
                                    {
                                        returnBook.BookCount++;
                                    }
                                }
                                System.Console.WriteLine("The Book has been Returned");
                                break;

                            }
                        
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("No books are there to return");
                }
            }
        }

    }
}