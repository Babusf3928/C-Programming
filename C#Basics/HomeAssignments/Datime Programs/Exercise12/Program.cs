using System;
namespace Exercise12;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month :");
        DateTime month = DateTime.ParseExact(Console.ReadLine(),"MM",null);
        System.Console.WriteLine("Enter the year :");
        DateTime year = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        System.Console.WriteLine($"The number of days in {month.ToString("MMMM")} is {DateTime.DaysInMonth(year.Year,month.Month)} days");
    }
}