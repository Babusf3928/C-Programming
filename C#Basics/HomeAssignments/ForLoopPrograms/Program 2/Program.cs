using System;
namespace Program2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i;
            double sum=0;
            System.Console.WriteLine("Enter ten numbers:");
            for(i=0;i<10;i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            System.Console.WriteLine("The Sum of the numbers = "+sum);
            System.Console.WriteLine("The Average of the numbers = "+(sum/10));
        }
    }
}