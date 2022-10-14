using System;
namespace Program9
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int modulus,temp,sum=0;
            for(temp=number;number !=0;number = number/10)
            {
                modulus = number % 10;
                sum += (modulus*modulus*modulus);
            }
            if(temp==sum)
            {
                System.Console.WriteLine("The given number is an Armstrong number");
            }
            else
            {
                System.Console.WriteLine("It is not an Armstrong number");
            }
        }
    }
}