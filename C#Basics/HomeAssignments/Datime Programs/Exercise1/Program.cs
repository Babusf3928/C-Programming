using System;
namespace Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        DateTime [] dates = {DateTime.Now,new DateTime(2016,08,16,09,28,0),new DateTime(2011,05,28,10,35,0),new DateTime(1979,12,25,14,30,0)};
        foreach(DateTime date in dates)
        {
            System.Console.WriteLine($"Days: {date.ToString("MM/dd/yyyy")}\tTime: {date.ToString("hh:mm:ss")}");
            System.Console.WriteLine($"Days: {date.ToString("MM/dd/yyyy")}\tTime: {date.ToString("HH:mm tt")}");
        }
    }
}