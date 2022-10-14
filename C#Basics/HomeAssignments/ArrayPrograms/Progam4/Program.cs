using System;
namespace Program4
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
            int temp = elements[0];
            for(i = 0;i<size;i++)
            {
                if(elements[i]>temp)
                {
                    temp = elements[i];
                }
            }
            System.Console.WriteLine("The largest number in the elements is : "+temp);
            
        }
    }
}