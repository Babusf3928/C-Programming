using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the speed : ");
            double speed = double.Parse(Console.ReadLine());
            if(speed <=10)
            {
                System.Console.WriteLine("slow");
            }
            else if(speed >10 && speed <=50)
            {
                System.Console.WriteLine("average");
            }
            else if(speed >50 && speed <=150)
            {
                System.Console.WriteLine("fast");
            }
            else if(speed >150 && speed <=1000)
            {
                System.Console.WriteLine("ultra fast");
            }
            else
            {
                System.Console.WriteLine("extremely fast");
            }
        }
    }
}