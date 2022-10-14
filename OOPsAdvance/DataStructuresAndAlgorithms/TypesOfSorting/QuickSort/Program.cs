using System;
namespace QuickSort;
class Program
{
    public static void Main(string[] args)
    {
        int [] number={18,19,1,5,7,3,20};
        int length = number.Length;
        int temp = number[0];
        int i;
        for(i=0;i<length;i++)
        {
            if(temp<number[i])
            {
                temp=number[i];
                
            }
        }
        for(i=0;i<length;i++)
        {
            System.Console.Write(number[i]+" ");
        }
    }
}