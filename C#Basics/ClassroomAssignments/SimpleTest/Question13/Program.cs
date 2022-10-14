using System;
namespace Question13
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number : ");
            int number = int.Parse(Console.ReadLine());
            int i;
            for(i = 1;i<=20;i++)
            {
                System.Console.WriteLine(number+"*"+i+"= "+(number*i));
            }
        }
    }
}