using System;
namespace Program9
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string : ");
            string word = Console.ReadLine().ToLower();
            System.Console.WriteLine("Enter the substring to search :");
            string search = Console.ReadLine().ToLower();
            string [] word1 = word.Split(" ");
            int flag =0;
            for(int i=0;i<word1.Length;i++)
            {
                if(word1[i]==search)
                {
                    flag++;
                    System.Console.WriteLine("The substring exists in the string");
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("The substring is not in the string");
            }           
        }
    }
}