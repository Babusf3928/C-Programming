using System;
namespace Program11;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string :");
        string word = Console.ReadLine();
        char [] word1 = word.ToCharArray();
        string endWord = "";
        for(int i = 0;i<word.Length;i++)
        {
            if(!(endWord.Contains(word1[i])))
            {
                endWord+=word1[i];
            }
        }
        System.Console.WriteLine("The string after removing dublicates is "+endWord);        
    }
}