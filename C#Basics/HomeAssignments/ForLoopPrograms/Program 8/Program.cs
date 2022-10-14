using System;
namespace Program8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,j,k,space,t=1;
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            space = rows + 4-1;
            for(i=1;i<=rows;i++)
            {
                for(k = space;k>=1;k--)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=i;j++)
                {
                    Console.Write((t++)+" ");
                }
                Console.Write("\n");    
                space--;
            }
        }
    }
}
