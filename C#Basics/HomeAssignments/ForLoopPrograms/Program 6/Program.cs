using System;
namespace Program6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            for(i=1;i<=rows;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");    
                
            }
        }
    }
}