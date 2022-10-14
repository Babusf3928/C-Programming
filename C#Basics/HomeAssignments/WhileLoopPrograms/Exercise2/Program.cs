using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the count: ");
            int count = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while(i<=count)
            {
                sum = sum + (i*i);
                i++;
            }
            Console.WriteLine("The sum of the squares of the numbers is = "+sum);
        }
    }
}