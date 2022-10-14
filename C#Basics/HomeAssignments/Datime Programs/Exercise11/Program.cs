using System;
namespace Exercise11;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in dd/MM/yyyy format ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("The date of the day is "+date.ToShortDateString());
        for(int i=0;i<12;i++)
        {
            DateTime month = date.AddMonths(i);
            System.Console.WriteLine(month.ToString("MMMM"));
        }
    }
}