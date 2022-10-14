using System;
namespace Program2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string condition;
            int sum = 0;
            do
            {
                System.Console.WriteLine("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                if(number >0)
                {
                    sum += number; 
                }
                System.Console.WriteLine("Do you want to sum the numbers: Press 'yes' to sum  or 'no'to continue");
                condition = Console.ReadLine().ToLower();
                if(condition=="yes")
                {
                    System.Console.WriteLine("The sum of the given numbers = "+sum);
                }
            }while(condition == "no");
        }
    }
}
