using System;
namespace Exercise14;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month :");
        DateTime month = DateTime.ParseExact(Console.ReadLine(),"MM",null);
        System.Console.WriteLine("Enter the number of leaves taken :");
        int leaves = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the salary per day");
        double salary = double.Parse(Console.ReadLine());
        int dateTime = DateTime.DaysInMonth(0001,month.Month)-leaves;
        System.Console.WriteLine("The salary is "+dateTime*salary);        
    }
}