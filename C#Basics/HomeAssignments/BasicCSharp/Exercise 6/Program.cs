using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Price: ");
            float price = float.Parse(Console.ReadLine());
            double interest = 0.18;
            Console.WriteLine("The Total price is :"+(price+(price*interest)));
        }
    }
}