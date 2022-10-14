using System;
namespace CharacterSearch;
class Program
{
    public static void Main(string[] args)
    {
        char [] letters = {'a','b','c','d','e','f','g','h','i','j','k'};
        int length = letters.Length;
        System.Console.WriteLine("Enter the letter to search : ");
        char search = char.Parse(Console.ReadLine().ToLower());
        int i ;
        int flag=0;
        for(i=0;i<length;i++)
        {
            if(letters[i]==search)
            {
                System.Console.WriteLine($"The letter {search} is found in the array in the position {i} ");
                flag++;
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("The letter is not found in the array");
        }
    }
}