using System;
namespace StringSearch;
class Program
{
    public static void Main(string[] args)
    {
        string [] words={"lion","tiger","monkey","sparrow","cheetah"};
        int length = words.Length;
        System.Console.WriteLine("Enter the string to search : ");
        string search = Console.ReadLine().ToLower();
        int i;
        int flag=0;
        for(i=0;i<length;i++)
        {
            if(words[i]==search)
            {
                System.Console.WriteLine($"The string {search} is found in this array at position {i}");
                flag++;
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("The string is not in the array");
        }
    }
}