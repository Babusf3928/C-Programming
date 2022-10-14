using System;
namespace Program4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Input the number to show that tables:");
            int number = int.Parse(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                Console.WriteLine(number+" x "+i+" = "+(number*i));
            }
        }
    }
}