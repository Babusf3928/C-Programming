using System;
namespace Exercise6;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date = DateTime.Now.AddDays(40);
        System.Console.WriteLine("The day of the date "+date+" is "+date.DayOfWeek);
    }
}