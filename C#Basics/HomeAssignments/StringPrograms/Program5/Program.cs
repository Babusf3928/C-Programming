using System;
namespace Program5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string 1: ");
        string word1 = Console.ReadLine();
        System.Console.WriteLine("Enter the string 1: ");
        string word2 = Console.ReadLine();
        int compare =word1.CompareTo(word2);
        if(compare==0)
        {
            System.Console.WriteLine("The two strings are same");
        }
        else
        {
            System.Console.WriteLine("The two strings are not same");
        }
        
    }
}