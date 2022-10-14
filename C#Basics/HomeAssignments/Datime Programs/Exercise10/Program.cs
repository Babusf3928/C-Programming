using System;
namespace Exercise10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in dd/MM/yyyy : ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        DateTime yesterday = date.AddDays(-1);
        DateTime tommorrow = date.AddDays(1);
        System.Console.WriteLine("Yesterday is "+yesterday.ToString("dd/MM/yyyy"));
        System.Console.WriteLine("Today is "+date.ToString("dd/MM/yyyy"));
        System.Console.WriteLine("Tommorrow is "+tommorrow.ToString("dd/MM/yyyy"));

    }
}