using System;
namespace Program3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Swapping();
            void Swapping()
            {
                System.Console.WriteLine("Enter the number 1:");
                int number1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the number 2:");
                int number2 = int.Parse(Console.ReadLine());
                number1 = number1 + number2;
                number2 = number1 - number2;
                number1 = number1 - number2;
                System.Console.WriteLine("The number 1 is "+number1+"\nThe number 2 is "+number2);
            }
        }
    }
}
