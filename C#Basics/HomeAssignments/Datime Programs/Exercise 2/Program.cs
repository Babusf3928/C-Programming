using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date and time in the format dd/MM/yyyy HH:mm:ss tt");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        System.Console.WriteLine("Complete date in 24 hour format: "+date.ToString("dd/MM/yyyy hh:mm:ss tt"));
        System.Console.WriteLine("Short date: "+date.ToShortDateString());
        System.Console.WriteLine("Long date: "+date.ToLongDateString());
        System.Console.WriteLine("Complete date in 12 hour format: "+date.ToString("dd/MM/yyyy hh:mm:ss tt"));
        System.Console.WriteLine("To date only: ");
    }
}