using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the degree in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double number1 = 9.00;
            double number2 = 5.00;
            double fahrenheit = celsius*(number1/number2)+32.00;
            System.Console.WriteLine("Degree in Fahrenheit = "+fahrenheit);
        }
    }
}