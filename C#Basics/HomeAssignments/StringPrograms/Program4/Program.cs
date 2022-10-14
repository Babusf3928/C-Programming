using System;
namespace Program4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word = Console.ReadLine();
        string [] word1 = word.Split(" ");
        System.Console.WriteLine("Total number of words in the string is "+word1.Length);         
    }
}