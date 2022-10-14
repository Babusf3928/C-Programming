using System;
namespace Program3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the month number :");
            int month = int.Parse(Console.ReadLine());
            switch(month)
            {
                case 1:
                {
                    Console.WriteLine("Month have 31 days");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Month have 28 days");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Month have 31 days");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Month have 30 days");
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Month have 31 days");
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Month have 30 days");
                    break;
                }
                case 7:
                {
                    Console.WriteLine("Month have 31 days");
                    break;
                }
                case 8:
                {
                    Console.WriteLine("Month have 31 days");
                    break;
                }
                case 9:
                {
                    Console.WriteLine("Month have 30 days");
                    break;
                }
                case 10:
                {
                    Console.WriteLine("Month have 31 days");
                    break;
                }
                case 11:
                {
                    Console.WriteLine("Month have 30 days");
                    break;
                }
                case 12:
                {
                    Console.WriteLine("Month have 31 days");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }    
        }
    }
}
