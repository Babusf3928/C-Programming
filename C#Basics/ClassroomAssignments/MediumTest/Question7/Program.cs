using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the  starting number : ");
            int startnumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the number of terms : ");
            int term = int.Parse(Console.ReadLine());
            int difference = 2,number1,number=startnumber;
            int i,sum = startnumber;
            System.Console.WriteLine("The series of elements are : ");
            System.Console.Write(startnumber+" ");
            for(i = 2;i<=term;i++)
            {
                number1 = number+difference;
                System.Console.Write(number1+" ");
                number = number1;
                sum = sum + number;
            }
            System.Console.WriteLine("\nThe Sum of the series = "+sum);

        }
    }
}