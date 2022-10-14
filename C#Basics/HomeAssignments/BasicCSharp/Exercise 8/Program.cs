using System;
namespace Exercise8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length in meters: ");
            double meter = double.Parse(Console.ReadLine());
            Console.WriteLine("The Length in cm = "+ (meter*100));
            Console.WriteLine("The Length in mm = "+ ((meter*100)*10));
            Console.WriteLine("The Length in Inch = "+ (39.3*meter));
            Console.WriteLine("The Length in Foot = "+ (12*meter));
            Console.WriteLine("The Length in Mile = "+ (0.0006213715277778*meter));
        }
    }
}