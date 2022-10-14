using System;
namespace Program4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number;
            string condition;
            do
            {
                System.Console.WriteLine("Enter the number :");
                number = int.Parse(Console.ReadLine());
                if(number >0 && number >= 1 && number<=10)
                {
                    System.Console.WriteLine("The number is "+number+" and it is in the range of (1-10)");
                }
                else
                {
                    System.Console.WriteLine("Invalid input");
                }
                System.Console.WriteLine("Please enter 'yes'to enter the input again and 'no' to stop the program");
                condition = Console.ReadLine().ToLower();
            }while(condition == "yes");
        }
    }
}
