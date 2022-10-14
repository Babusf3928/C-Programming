using System;
namespace Program4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fibanocci();
            void Fibanocci()
            {
            Console.WriteLine("Enter the count: ");
            int count = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;
            int number3 ;
            System.Console.WriteLine("The Fibanooci Series of "+count+" numbers is:");
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
}