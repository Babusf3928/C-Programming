using System;
namespace Program7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string : ");
        string word = Console.ReadLine().ToLower();
        char [] word1 = word.ToCharArray(); 
        int vowel = 0;
        int consonant = 0;
        int i ;
        for(i = 0;i<word1.Length;i++)
        {
            if(word1[i]=='a' ||word1[i]=='e' ||word1[i]=='i' ||word1[i]=='o' ||word1[i]=='u')
            {
                vowel +=1;
            }
            else if(word1[i]>65)
            {
                consonant +=1;
            }
        }

        System.Console.WriteLine("Number of vowels in the string is "+vowel);
        System.Console.WriteLine("Number of consonants in the string is "+consonant);
                
    }
}