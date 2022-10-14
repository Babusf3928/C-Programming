using System;
namespace Program3;
class Program
{
    public static void Main(string[] args)
    {
        string finalWord = " ";
        System.Console.WriteLine("Enter the string: ");
        string word = Console.ReadLine();
        char [] word1 = word.ToCharArray();
        int i;
        for(i=word.Length-1;i>=0;i--)
        {
            System.Console.Write(word1[i]+finalWord);
        }        
    }
}