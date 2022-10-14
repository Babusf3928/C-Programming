using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public enum BookStatus{Default,Issued,Returned}
    public class BorrowDetails
    {
        private static int s_borrowId=300;
        public string BorrowID { get; }
        public string BookId { get; set; }
        public string RegistrationId { get; set; }
        public DateTime BorrowedDate {get; set; }
        public BookStatus Status { get; set; }

        public BorrowDetails(string bookId,string registrationId,DateTime borrowedDate,BookStatus status)
        {
            s_borrowId++;
            BorrowID="LB"+s_borrowId;
            BookId=bookId;
            RegistrationId=registrationId;
            BorrowedDate=borrowedDate;
            Status=status;
        }
    }
}