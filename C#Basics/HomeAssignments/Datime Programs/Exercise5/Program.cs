using System;
namespace Exercise5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter year : ");
        DateTime dateTime;
        dateTime = DateTime.ParseExact(Console.ReadLine(),"yyyy",null );
        for(int i = 0;i<=10;i++)
        {
            DateTime dateDisplay = dateTime.AddYears(i);
            System.Console.WriteLine($"{dateDisplay.ToString("dd/MM/yyyy")}: day {dateDisplay.DayOfYear} of {dateDisplay.Year}");
        }       
    }
}