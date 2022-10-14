using System;
namespace Program6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string : ");
        string word = Console.ReadLine().ToLower();
        char [] word1 = word.ToCharArray();
        int i;
        int alphabets =0;
        int digits =0;
        int specialChar =0;
        for(i =0;i<word1.Length;i++)
        {
            if(word1[i]>65)
            {
                alphabets +=1;
            }
            else if(word1[i]>=48 && word1[i]<=57)
            {
                digits +=1;
            }
            else
            {
                specialChar +=1;
            }
        }

        System.Console.WriteLine("The number of alphabets in the string is "+alphabets);
        System.Console.WriteLine("The number of digits in the string is "+digits);
        System.Console.WriteLine("The number of special characters in the string is "+specialChar);
                
    }
}