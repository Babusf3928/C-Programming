using System;
namespace Exercise9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed in km/hr: ");
            double speed = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time in seconds: ");
            double time = double.Parse(Console.ReadLine());
            double number1 = 5;
            double number2 = 18;
            Console.WriteLine("Distance travelled in meters = "+ (speed*time*(number1/number2)));
            
        }
    }
}