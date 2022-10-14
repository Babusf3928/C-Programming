using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number of terms: ");
            int term = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;
            int i,number3;
            System.Console.WriteLine("Here is the Fibanocci series upto "+term+" terms :");
            System.Console.Write(number1+" "+number2+" ");
            for(i = 1;i <term-1;i++)
            {
                number3 = number1 + number2;
                System.Console.Write(number3+" ");
                number1 = number2;
                number2 = number3;
            }
        }
    }
}