using System;
namespace Program3
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
            int sum =0;
            for(i = 0;i<size;i++)
            {
                sum += elements[i];
            }
            System.Console.WriteLine("The sum of numbers in the elements is : "+sum);
        }
    }
}