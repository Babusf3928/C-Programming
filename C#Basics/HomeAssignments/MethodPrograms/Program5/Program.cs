using System;
namespace Program5
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrimeNumber();
            void PrimeNumber()
            {
            System.Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int i,temp = 0;
            for(i = 1;i<= number;i++)
            {
                if(number%i==0)
                {
                    temp++;
                }
            }
            if(temp==2)
            {
                System.Console.WriteLine(number+" is a Prime Number");
            }
            else
            {
                System.Console.WriteLine(number+" is not a Prime Number");
            }
            }
        }
    }
}