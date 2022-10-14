using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number : ");
            int number = int.Parse(Console.ReadLine());
            int number1 = number;
            int modulus,temp=0;
            while(number !=0)
            {
                modulus = number % 10;
                temp = (temp*10)+ modulus;
                number = number/10;
            }
            if(temp == number1)
            {
                System.Console.WriteLine(number1+" is palindrome");
            }
            else
            {
                System.Console.WriteLine(number1+" is not palindrome");
            }
        }
    }
}