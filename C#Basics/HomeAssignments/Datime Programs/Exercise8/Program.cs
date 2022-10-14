using System;
namespace Exercise8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date and time in dd/MM/yyyy hh:mm:yyyy tt");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter the date and time in dd/MM/yyyy hh:mm:yyyy tt");
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        int result = DateTime.Compare(date1,date1);
        if(result<0)
        {
            System.Console.WriteLine($"{date1} is earlier than {date2}");
        }
        else if(result==0)
        {
            System.Console.WriteLine($"{date1} is same as {date2}");
        }
        else
        {
            System.Console.WriteLine($"{date1} is later than {date2}");
        }
        
    }
}