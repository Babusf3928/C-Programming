using System;
namespace Program5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int [] elements= new int[size];
            int i;
            for(i = 0;i<size;i++)
            {
                System.Console.WriteLine("Enter the number : ");
                elements[i] = int.Parse(Console.ReadLine());
            }
            int [] even = new int[size];
            int [] odd =  new int[size];
            int j =0,k=0;
            for(i = 0;i<size;i++)
            {
                if(elements[i] % 2 ==0)
                {
                    even[j] = elements[i];
                    j++;
                }
                else
                {
                    odd[k] = elements[i];
                    k++;
                }
            }
            System.Console.Write("The even numbers in the elements are: ");
            for(i = 0;i<j;i++)
            {
                System.Console.Write(even[i]+", ");
            }
            System.Console.WriteLine("\n");
            System.Console.Write("The odd numbers in the elements are: ");
            for(i = 0;i<k;i++)
            {
                System.Console.Write(odd[i]+", ");
            }
        }
    }
}