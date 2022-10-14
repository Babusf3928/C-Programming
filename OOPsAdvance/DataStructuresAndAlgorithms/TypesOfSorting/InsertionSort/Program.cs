using System;
namespace InsertionSort;
class Program
{
    public static void Main(string[] args)
    {
        int [] number = {18,19,1,5,7,3,20};
        int length = number.Length;
        int i,j,k,temp;
        for(i=1;i<=length-1;i++)
        {
            k=number[i];
            for(j=i-1; j>=0 && k<number[j];j--)
            {
                temp=number[j];
                number[j]=number[j+1];
                number[j+1]=temp;
            }
            
        }
        
        for(i=0;i<=length-1;i++)
        {
            System.Console.Write(number[i]+" ");
        }

    }
}