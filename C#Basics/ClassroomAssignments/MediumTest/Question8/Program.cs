using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string : ");
            string input = Console.ReadLine();
            char [] numbers = input.ToCharArray();
            foreach(char number in numbers)
            {
                if(number / 1==0)
                {
                    System.Console.WriteLine(number);
                }
            }
        }
    }
}