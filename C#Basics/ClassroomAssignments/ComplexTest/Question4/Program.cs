using System;
namespace Question4
{
    class Project
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string: ");
            string  word = Console.ReadLine();
            char [] word1= word.ToCharArray();
            string [] word2= new string[word.Length];
            int i;
            for(i = 1;i<word.Length;i++)
            {
                if(word[i] != word[i])
                {
                    System.Console.WriteLine(word2[i]);
                }
            }
        }
    }
}