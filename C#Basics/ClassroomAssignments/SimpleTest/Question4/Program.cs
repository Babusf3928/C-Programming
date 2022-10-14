using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the amount : ");
            double rupees = double.Parse(Console.ReadLine());
            double usd = rupees*(1.22/100);
            double eur = rupees*(1.27/100);
            double cny = rupees*(8.79/100);
            System.Console.WriteLine("The amount in rate(Rupees) = "+rupees);
            System.Console.WriteLine("The amount in USD = "+usd);
            System.Console.WriteLine("The amount in EUR = "+eur);
            System.Console.WriteLine("The amount in CNY = "+cny);
        }
    }
}