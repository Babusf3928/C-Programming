using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the integer : ");
            int integer = int.Parse(Console.ReadLine());
            if(integer<100)
            {
                System.Console.WriteLine("Less than 100");
            }
            else if(integer >= 100 && integer <=200)
            {
                System.Console.WriteLine("Between 100 and 200");
            }
            else if(integer > 200)
            {
                System.Console.WriteLine("Greater than 200");
            }
        }
    }
}