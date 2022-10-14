using System;
namespace SelectionSort;
class Program
{
    public static void Main(string[] args)
    {
        int [] number={18,19,1,5,7,3,20};
        int length = number.Length;
        int minimum,minIndex;
        int temp = 0;
        int i,j;
        for(i=0;i<length;i++)
        {
            minimum=number[i];
            minIndex=i;
            for(j=i;j<length;j++)
            {
                if(number[j]<minimum)
                {
                    minimum=number[j];
                    minIndex=j;
                }
            }
            if(minimum<number[i])
            {
                temp=number[i];
                number[i]=number[minIndex];
                number[minIndex]=temp;
            }
        }
        for(i=0;i<length;i++)
        {
            System.Console.Write(number[i]+" ");
        }
    }   
}