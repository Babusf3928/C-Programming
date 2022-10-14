using System;
namespace Question15
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number : ");
            int number = int.Parse(Console.ReadLine());
            int i,temp = 0;
            for(i = 1;i<=number;i++)
            {
                if(number % i ==0)
                {
                    temp++;
                }
            }
            if(temp == 2)
            {
                System.Console.WriteLine("It is a prime number");
            }
            else
            {
                System.Console.WriteLine("It is not a prime number");
            }
        }
    }
}