using System;
namespace Exercise5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int modulus;
            while(number > 0)
            {
                modulus = number % 10;
                sum += modulus;
                number = number / 10;
            }
            Console.WriteLine("The sum of the digits = "+sum);
        }
    }
}
