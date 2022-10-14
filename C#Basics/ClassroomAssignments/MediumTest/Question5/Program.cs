using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the n term : ");
            int term = int.Parse(Console.ReadLine());
            int i;
            System.Console.WriteLine("Leap years from 1 to "+term+":");
            for(i = 1;i<=term;i++)
            {
                if((i % 4 == 0 && i % 100 !=0) || i % 400 ==0)
                {
                    System.Console.Write(i+" ");
                }
            }
        }
    }
}