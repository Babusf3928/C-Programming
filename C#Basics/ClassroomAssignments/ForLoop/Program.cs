using System;
namespace ForLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i;
            for( i=0; i <= 25 ; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.WriteLine("Enter number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for(i= number1 ; i <= number2 ; i++)
            {
                sum = sum + (i*i);
            }
            Console.WriteLine("The Sum of the Squares of the numbers is "+ sum);
        }
    }
}