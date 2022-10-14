using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string : ");
            string word = Console.ReadLine();
            string reverse = "";
            int i;
            for(i = word.Length-1;i>=0;i--)
            {
                reverse = reverse + word[i];
            }
            if(word==reverse)
            {
                System.Console.WriteLine(word+" is a palindrome");
            }
            else
            {
                System.Console.WriteLine(word+" is not a palindrome");
            }
        }
    }
}