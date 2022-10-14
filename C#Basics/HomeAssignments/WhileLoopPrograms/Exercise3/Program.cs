using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the count: ");
            int count = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;
            int number3 ;
            Console.Write(number1+" "+number2+" ");
            while((count-2) !=0)
            {
                number3= number1 + number2;
                Console.Write(number3+" ");
                number1 = number2;
                number2 = number3;
                --count;
            }
        }
    }
}
