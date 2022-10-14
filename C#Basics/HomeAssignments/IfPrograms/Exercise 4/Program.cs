using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());
            if(number1 > number2)
            {
                Console.WriteLine("The first number is the greatest among three numbers");
            }
            else if(number2 > number3)
            {
                Console.WriteLine("The second number is the greatest among three numbers");
            }
            else if(number3 > number1)
            {
                Console.WriteLine("The third number is the greatest among three numbers");
            }
            else
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
