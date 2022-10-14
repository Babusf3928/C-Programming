using System;
namespace Program13;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string :");
        string word = Console.ReadLine();
        char [] word1 = word.ToCharArray();
        int value =0;
        for(int i = 0;i<word1.Length;i++)
        {
            if(word1[i]>='0' && word1[i]<='9')
            {
                value+=word1[i]-48;
            }
        }
        System.Console.WriteLine("The sum of digits in the string is "+value);

    }
}