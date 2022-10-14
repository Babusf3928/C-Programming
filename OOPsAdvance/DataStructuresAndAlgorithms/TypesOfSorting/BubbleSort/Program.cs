using System;
namespace BubbleSort;
class Program
{
    public static void Main(string[] args)
    {
        int [] number = {18,19,1,5,7,3,20};
        int length = number.Length;
        int i,j,temp;
        for(i=0;i<=length-1;i++)
        {
            for(j=i+1;j<=length-1;j++)
            {
                if(number[i]>number[j])
                {
                    temp=number[i];
                    number[i]=number[j];
                    number[j]=temp;
                }
            }
        }
        for(i=0;i<=length-1;i++)
        {
            System.Console.Write(number[i]+" ");
        }
    }
}