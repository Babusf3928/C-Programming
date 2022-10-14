using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Radius = ");
           float radius = float.Parse(Console.ReadLine());
           Console.WriteLine("Height = ");
           float height = float.Parse(Console.ReadLine());
           Console.WriteLine("Volume : "+(3.14*(radius*radius)*height));
            
        }
    }
}