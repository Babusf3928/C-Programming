using System;
namespace Program2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string finalWord = " ";
            System.Console.WriteLine("Enter the string: ");
            string word = Console.ReadLine();
            char [] word1 = word.ToCharArray();
            int i;
            for(i=0;i<word.Length;i++)
            {
                System.Console.Write(word1[i]+finalWord);
            }
        }
    }
}