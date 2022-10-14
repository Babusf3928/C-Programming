using System;
namespace Question12
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,sum=0;
            for(i = 1; i<=99;i++)
            {
                if(i % 2 !=0)
                {
                    sum += (i*i);
                }
            }
            System.Console.WriteLine("The sum of squares of ood values in the range 1-99 = "+sum);
        }
    }
}