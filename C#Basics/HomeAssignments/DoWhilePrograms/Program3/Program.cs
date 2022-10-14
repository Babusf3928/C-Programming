using System;
namespace Program3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string condition ;
            do
            {
            Console.WriteLine("Enter the count: ");
            int count = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;
            int number3 ;
            System.Console.WriteLine("Here are the fibanacci series upto "+count+" terms");
            Console.Write(number1+" "+number2+" ");
            while((count-2) !=0)
            {
                number3= number1 + number2;
                Console.Write(number3+" ");
                number1 = number2;
                number2 = number3;
                --count;
            } 
            System.Console.WriteLine("\nDo you want to continue: Press 'yes' to continue 'no' to end the program");
            condition = Console.ReadLine().ToLower();
            }while(condition=="yes");
        }
    }
}
