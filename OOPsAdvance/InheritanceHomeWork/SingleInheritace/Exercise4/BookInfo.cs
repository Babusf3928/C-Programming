using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise4
{
    public class BookInfo:DepartmentDetails
    {
        private static int s_bookId=1000;
        public string BookID { get; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string departmentName,Degree degree, string bookName,string authorName,double price):base(departmentName,degree)
        {
            s_bookId++;
            BookID="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public void BookDetails()
        {
            ShowDepartment();
            System.Console.WriteLine($"Book ID is {BookID}\nBook name is {BookName}\nAuthor Name is {AuthorName}\nBook price is {Price}");
        }
    }
}