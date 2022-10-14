using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of Celsius:");
            float celsius = float.Parse(Console.ReadLine());
            float num1 = 9;
            float num2 = 5;
            float fahrenheit = celsius*(num1/num2)+ 32;
            float kelvin = celsius+ 273;
            Console.WriteLine("Kelvin = "+kelvin);
            Console.WriteLine("Fahrenheit = "+fahrenheit);
        }
    }
}
