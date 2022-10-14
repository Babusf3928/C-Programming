using System;
namespace Exercise9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in dd/MM/yyyy : ");
        DateTime dateTime1 = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        System.Console.WriteLine("Enter the date in dd/MM/yyyy : ");
        DateTime dateTime2 = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        for(int i = dateTime1.Year;i<=dateTime2.Year;i++)
        {
            if(DateTime.IsLeapYear(i))
            {
                DateTime date1 = new DateTime(i,2,29);
                DateTime date2 = date1.AddYears(1);
                System.Console.WriteLine($"Is Leap Year {i}");
                System.Console.WriteLine($"One year from {date1.ToShortDateString()} to {date2.ToShortDateString()}");
            }
        }
                
    }
}