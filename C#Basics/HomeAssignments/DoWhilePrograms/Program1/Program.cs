using System;
namespace Program1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string condition;
            do
            {
                System.Console.WriteLine("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                if(number % 2==0)
                {
                    System.Console.WriteLine("Result: The given number is an even number");
                }
                else
                {
                    System.Console.WriteLine("Result: The given number is an odd number");
                }
                System.Console.WriteLine("Do you want to continue: Press 'yes' or 'no'");
                condition = Console.ReadLine().ToLower();
            }while(condition == "yes");
        }
    }
}
