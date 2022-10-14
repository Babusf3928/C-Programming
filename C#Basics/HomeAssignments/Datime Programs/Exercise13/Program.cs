using System;
namespace Exercise13;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the day : ");
        int day = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the month : ");
        int month = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the year : ");
        int year = int.Parse(Console.ReadLine());
        DateTime date =new DateTime(year,month,day);
        System.Console.WriteLine("The formatted date is "+date.ToString("dd/MM/yyyy"));
        System.Console.WriteLine("The day of week is "+date.DayOfWeek);

    }
}