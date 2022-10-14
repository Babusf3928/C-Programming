using System;
namespace Program9
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int [,] matrix1= new int[size,size];
            int [,] matrix2= new int[size,size];
            int [,] multiplication= new int[size,size];
            int i,j,k,sum =0;
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    System.Console.WriteLine("Enter the number : ");
                    matrix1[i,j] = int.Parse(Console.ReadLine());
                }    
            }
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    System.Console.WriteLine("Enter the number : ");
                    matrix2[i,j] = int.Parse(Console.ReadLine());
                }    
            }
            System.Console.WriteLine("The numbers in the matrix1 are: ");
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    System.Console.Write(matrix1[i,j]+" ");
                }    
                System.Console.WriteLine("\n");
            }
            System.Console.WriteLine("The numbers in the matrix2 are: ");
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    System.Console.Write(matrix2[i,j]+" ");
                }    
                System.Console.WriteLine("\n");
            }
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    multiplication[i,j] = 0;
                for(i = 0;i<size;i++)
                {
                    for(j = 0;j<size;j++)
                    {
                        for(k = 0;k<size;k++)
                        {
                            sum = sum + (matrix1[i,k]*matrix2[k,j]);
                            multiplication[i,j]=sum;
                        }
                    }
                }
                }
            }
            System.Console.WriteLine("The Multiplication of two matrices is: ");
            for(i = 0;i<size;i++)
            {
                for(j = 0;j<size;j++)
                {
                    System.Console.Write(multiplication[i,j]+" ");
                }  
                System.Console.WriteLine("\n");
            }  
        }
    }
}