using System;
namespace Program10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int [,] matrix= new int[size,size];
            int [,] transpose= new int[size,size];
            int i,j;
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    System.Console.WriteLine("Enter the number : ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }    
            }
            System.Console.WriteLine("The numbers in the matrix are: ");
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    System.Console.Write(matrix[i,j]+" ");
                }    
                System.Console.WriteLine("\n");
            }
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    transpose[j,i]=matrix[i,j];
                }    
            }
            System.Console.WriteLine("The Transpose of the matrix is: ");
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    System.Console.Write(transpose[i,j]+" ");
                }  
                System.Console.WriteLine("\n");
            }  
        }
    }
}