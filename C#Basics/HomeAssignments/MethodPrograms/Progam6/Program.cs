using System;
namespace Program6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Factorial();
            void Factorial()
            {
                System.Console.WriteLine("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                int i,factorial = 1;
                for(i=number;(i<=number && i>0);i--)
                {
                    factorial *= i;
                }
                System.Console.WriteLine("The factorial of the "+number+" is "+factorial);
            }
        }
    }
}