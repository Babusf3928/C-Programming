using System;
namespace Program7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,j,k,space;
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            space = rows -1;
            for(i=1;i<=rows;i++)
            {
                for(j = space;j>=1;j--)
                {
                    Console.Write(" ");
                }
                for(k=1;k<=i;k++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");    
                space--;
            }
        }
    }
}