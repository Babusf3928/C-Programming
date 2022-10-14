using System;
namespace Datime
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime data = new DateTime(2021,8,10,10,40,32);
            Console.WriteLine("The Year is "+data.Year);
            System.Console.WriteLine("The Month is "+data.Month);
            System.Console.WriteLine("The Day is "+data.Day);
            System.Console.WriteLine("The Hour is "+data.Hour);
            System.Console.WriteLine("The Minute is "+data.Minute);
            System.Console.WriteLine("The Seocnds is "+data.Second);
            System.Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm:ss tt"));
            string order = Console.ReadLine();
            string [] main = order.Split(new [] {'/',':'}); 
        }
    }
}