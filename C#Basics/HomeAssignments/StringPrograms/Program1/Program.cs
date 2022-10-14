using System;
namespace Program1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string: ");
            string word = Console.ReadLine();
            int length = word.Length;
            System.Console.WriteLine("The Length of the string is: "+length);
        }
    }
}