using System;
namespace Program6
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
            int j,temp ;
            for(i = 0;i<size;i++)
            {
                for(j = i+1;j<size;j++)
                {
                    if(elements[i]>elements[j])
                    {
                        temp = elements[i];
                        elements[i] = elements[j];
                        elements[j] = temp;
                    }
                }
            }
            System.Console.Write("The asecending order of numbers in elements is : ");
            for(i=0;i<size;i++)
            {
                System.Console.Write(elements[i]+" ");
            }
            
            
        }
    }
}