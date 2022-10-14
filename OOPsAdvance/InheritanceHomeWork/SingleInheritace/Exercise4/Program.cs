using System;
namespace Exercise4;
class Program
{
    public static void Main(string[] args)
    {
        BookInfo book1 = new BookInfo("Chemical",Degree.Btech,"Thermodynamics","KV Narayanan",1000);
        book1.BookDetails();
    }
}
