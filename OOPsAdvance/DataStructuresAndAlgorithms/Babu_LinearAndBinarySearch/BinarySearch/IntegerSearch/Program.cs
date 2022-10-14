using System;
namespace IntegerSearch;
class Program
{
    public static void Main(string[] args)
    {
        int [] number ={1,10,5,4,8,2,6,3,7,9};
        System.Console.WriteLine("Enter the number to search : ");
        int search = int.Parse(Console.ReadLine());
        int length = number.Length;
        int i,j,temp;
        for(i=0;i<length;i++)
        {
            for(j=i+1;j<length;j++)
            {
                if(number[i]>number[j])
                {
                    temp = number[i];
                    number[i] = number[j];
                    number[j] = temp;
                }
            }
        }
        int begin =0,middle,end=length-1;
        int flag=0;
        while(begin<=end)
        {
            middle = (begin+end)/2;
            if(number[middle]==search)
            {   
                System.Console.WriteLine("The number is found in the given array");
                flag++;
                break;
            }
            else 
            {
                if(search<number[middle])
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
            System.Console.WriteLine("The number is not in the given array");
        }
        
    }
}
