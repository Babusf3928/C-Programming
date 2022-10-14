using System;
namespace MergeSort;
class Program
{
    public static void Main(string[] args)
    {
        int [] number = {18,19,1,5,7,3,20};
        int length = number.Length;
        int i,begin =0 ,end=length-1;
        
        Sort( number,begin,end);

        for(i=0;i<length;i++)
        {
            System.Console.Write(number[i]+" ");
        }
    }  
    public static void Sort(int [] number,int left ,int right)
    {
        int center;
        if(left <right)
        {
            center = (left+right)/2;
            Sort(number,left,center);
            Sort(number,center+1,right);
            Merge(number,left,center,right);
        }
    }

    public static void Merge(int [] number,int left,int center,int right)
    {
        int i,j,k,number1,number2;
        number1=(center-left)+1;
        number2=right-center;
        int [] leftArray = new int[number1];
        int [] rightArray = new int[number2];
        for(i=0;i<number1;i++)
        {
            leftArray[i]=number[left+i];
        }
        for(j=0;j<number2;j++)
        {
            rightArray[j]=number[center+1+j];
        }
        i=0;j=0;k=left;
        while(i<number1 && j<number2)
        {
            if(leftArray[i]<=rightArray[j])
            {
                number[k]=leftArray[i];
                i++;
            }
            else
            {
                number[k]=rightArray[j];
                j++;
            }
            k++;
        }
        while(i<number1)
        {
            number[k]=leftArray[i];
            i++;
            k++;
        }
        while(j<number2)
        {
            number[k]=rightArray[j];
            j++;
            k++;
        }
    }
}
