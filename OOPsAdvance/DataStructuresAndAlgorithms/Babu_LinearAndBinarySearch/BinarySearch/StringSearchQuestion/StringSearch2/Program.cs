using System;
namespace StringSearch2;
class Program
{
    public static void Main(string[] args)
    {
        string [] names = {"SF3001","SF3002","SF3003","SF3004","SF3005","SF3006","SF3007","SF3008","SF3009","SF3010"};
        int length = names.Length;
        System.Console.WriteLine("Enter the string to search : ");
        string search = Console.ReadLine();
        int begin=0,middle,end=length-1;
        int flag=0;
        while(begin<=end)
        {
            middle = (begin+end)/2;
            int value = search.CompareTo(names[middle]);
            if(value==0)
            {
                System.Console.WriteLine($"The string is found in the array in the position {middle}");
                flag++;
                break;

            }
            else 
            {
                if(value<0)
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
            System.Console.WriteLine("The string is not in the array");
        }
    }
}