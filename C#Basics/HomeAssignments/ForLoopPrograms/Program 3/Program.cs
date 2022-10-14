using System;
namespace Program3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            for(i=1;i<=terms;i++)
            {
                Console.WriteLine("Number is "+i+" and the cube of the number is "+(i*i*i));
            }
        }
    }
}