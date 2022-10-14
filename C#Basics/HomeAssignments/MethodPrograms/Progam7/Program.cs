using System;
namespace Program7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Palindrome();
            void Palindrome()
            {
                System.Console.WriteLine("Enter the string: ");
                string word = Console.ReadLine();
                int i;
                string reverse="" ;
                for(i=word.Length-1;i>=0;i--)
                {
                    reverse += word[i];
                }
                if(word==reverse)
                {
                    System.Console.WriteLine("It is a Palindrome");
                }
                else
                {
                    System.Console.WriteLine("It is not a Palindrome");
                }

            }
        }
    }
}