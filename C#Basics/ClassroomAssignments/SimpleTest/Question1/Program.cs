using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number in inch : ");
            double inch = double.Parse(Console.ReadLine());
            System.Console.WriteLine(inch+" inch is equal to "+(inch*2.54)+" centimeter");
        }
    }
}
