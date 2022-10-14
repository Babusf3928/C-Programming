using System;
namespace Program12;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string of numbers :");
        string number = Console.ReadLine();
        char [] number1 = number.ToCharArray();
        int temp = number1[0];
        int temp1 = 0;
        for(int i =0;i<number1.Length;i++)
        {
            if(number1[i]>temp)
            {
                temp = number1[i];
            }
        }
        for(int i =0;i<number1.Length;i++)
        {
            if(number1[i]<temp1)
            {
                temp1 = number1[i];
            }
        }
        System.Console.WriteLine("The maximum and minimum number of the said string is "+(temp-48)+","+temp1);
    }
}