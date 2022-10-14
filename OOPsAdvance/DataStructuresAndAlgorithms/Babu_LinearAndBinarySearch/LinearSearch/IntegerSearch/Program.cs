using System;
namespace IntegerSearch;
class Program
{
    public static void Main(string[] args)
    {
        int [] numbers = {1,2,3,4,5,6,7,8,9,10};
        int length = numbers.Length;
        System.Console.WriteLine("Enter the number to search : ");
        int search = int.Parse(Console.ReadLine());
        int i;
        int flag=0;
        for(i=0;i<length;i++)
        {
            if(numbers[i]==search)
            {
                System.Console.WriteLine("The number "+search+" has been found in the "+i+" position ");
                flag++;
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("The number is not in the given array");
        }
    }
}