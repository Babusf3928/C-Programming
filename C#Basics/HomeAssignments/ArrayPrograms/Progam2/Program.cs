using System;
namespace Program2
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
            System.Console.Write("The numbers in the elements are: ");
            for(i = 0;i<size;i++)
            {
                System.Console.Write(elements[i]+" ");
            }
            System.Console.WriteLine("\n");
            System.Console.Write("The numbers in the elements in reverse order are: ");
            for(i = size-1;(i<size && i>=0);i--)
            {
                System.Console.Write(elements[i]+" ");
            }
        }
    }
}