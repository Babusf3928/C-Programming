using System;
namespace DoWhileLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            string condition = "";
            do
            {
                Console.WriteLine("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                if(number % 2 == 0)
                {
                    Console.WriteLine("The number is an even number");
                }
                else
                {
                    Console.WriteLine("The number is an odd number");
                }
                Console.WriteLine("Do you want to check with another number");
                condition = Console.ReadLine().ToLower();
                if(condition != "yes" && condition != "no")
                {
                    Console.WriteLine("Your input is wrong.You have to enter a valid input");
                }


            }while(condition=="yes");
        }
    }
}