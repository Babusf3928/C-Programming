using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the row size of the array: ");
            int row1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the column size of the array: ");
            int column1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the row size of the array: ");
            int row2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the column size of the array: ");
            int column2 = int.Parse(Console.ReadLine());
            int [,] matrix1= new int[row1,column1];
            int [,] matrix2= new int[row2,column2];
            int [,] multiplication= new int[2,2];
            int i,j;
            for(i = 0;i<row1;i++)
            {
                for(j = 0;j<column1;j++)
                {
                    System.Console.WriteLine("Enter the number : ");
                    matrix1[i,j] = int.Parse(Console.ReadLine());
                }    
            }
            System.Console.WriteLine("The numbers in the matrix1 are: ");
            for(i = 0;i<row1;i++)
            {
                for(j = 0;j<column1;j++)
                {
                    System.Console.Write(matrix1[i,j]+" ");
                }    
                System.Console.WriteLine("\n");
            }
            for(i = 0;i<row2;i++)
            {
                for(j = 0;j<column2;j++)
                {
                    System.Console.WriteLine("Enter the number : ");
                    matrix2[i,j] = int.Parse(Console.ReadLine());
                }    
            }
            System.Console.WriteLine("The numbers in the matrix2 are: ");
            for(i = 0;i<row2;i++)
            {
                for(j = 0;j<column2;j++)
                {
                    System.Console.Write(matrix2[i,j]+" ");
                }    
                System.Console.WriteLine("\n");
            }
            System.Console.WriteLine("The Multiplication of two matrices is: ");
            for(i = 0;i<2;i++)
            {
                for(j = 0;j<2;j++)
                {
                    multiplication[i,j]=matrix1[i,j]*matrix2[i,j];
                    System.Console.Write(multiplication[i,j]+" ");
                }  
                System.Console.WriteLine("\n");
            }  
        }
    }
}