using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI*(radius*radius);
            double perimeter = 2*Math.PI*radius;
            System.Console.WriteLine("Area of the circle = "+area);
            System.Console.WriteLine("Perimeter of the circle = "+perimeter);
        }
    }
}
