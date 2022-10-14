using System;
namespace CharacterSearch;
class Program
{
    public static void Main(string[] args)
    {
        char [] letters = {'a','d','e','w','b','t','u','s'};
        int length = letters.Length;
        System.Console.WriteLine("Enter the character to search : ");
        char search = char.Parse(Console.ReadLine());
        int  begin =0,middle,end=length-1;
        int flag=0;
        while(begin<=end)
        {
            middle = (begin+end)/2;
            if(letters[middle]==search)
            {   
                System.Console.WriteLine("The Character is found in the given array");
                flag++;
                break;
            }
            else 
            {
                if(search<letters[middle])
                {
                    end = middle-1;
                    
                }
                else
                {
                    begin = middle+1;
                    
                }
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("The Character is not in the given array");
        }
    }
}