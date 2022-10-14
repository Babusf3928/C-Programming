using System;
namespace Exercise3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date and time in dd/MM/yyyy hh:mm:ss tt Format : ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        System.Console.WriteLine("Year = "+date.Year);
        System.Console.WriteLine("Month = "+date.Month);
        System.Console.WriteLine("Day = "+date.Day);
        System.Console.WriteLine("Hour = "+date.Hour);
        System.Console.WriteLine("Minute = "+date.Minute);
        System.Console.WriteLine("Second = "+date.Second);
        System.Console.WriteLine("MilliSeconds = "+date.Millisecond);
    }
}