using System;
namespace Exercise9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the month: ");
            string month = Console.ReadLine().ToLower();
            if(month == "december" || month== "january" || month== "febrauary")
            {
                Console.WriteLine("winter");
            }
            else if(month == "march" || month== "april" || month== "may")
            {
                Console.WriteLine("spring");
            }
            else if(month == "june" || month== "july" || month== "august")
            {
                Console.WriteLine("summer");
            }
            else if(month == "september" || month== "october" || month== "november")
            {
                Console.WriteLine("rainfall");
            }
        }
    }
}
