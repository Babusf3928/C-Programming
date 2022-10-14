using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year: ");
            int year = int.Parse(Console.ReadLine());
            if((year % 4==0 && year % 100 != 0) || (year % 400 ==0))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }
}