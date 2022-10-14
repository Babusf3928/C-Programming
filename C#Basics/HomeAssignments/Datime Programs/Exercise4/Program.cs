using System;
namespace Exercise4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in dd/MM/yyyy Formaat : ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("The day of the "+date.ToString("dd/MM/yyyy")+" is "+date.DayOfWeek);
    }
}