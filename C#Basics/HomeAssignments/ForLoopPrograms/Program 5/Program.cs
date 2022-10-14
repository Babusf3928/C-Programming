using System;
namespace Program5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i ,sum = 0;
            Console.WriteLine("Enter the number of terms: ");
            int terms = int.Parse(Console.ReadLine());
            System.Console.WriteLine("The Numbers are: ");
            for(i=1;i<=terms;i++)
            {
                Console.WriteLine(2*i-1);
                sum += 2*i-1;
            }
            System.Console.WriteLine("The Sum of the natural numbers is : "+sum);
        }
    }
}
