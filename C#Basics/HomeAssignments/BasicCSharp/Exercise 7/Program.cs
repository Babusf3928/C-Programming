using System;
namespace Exercise7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b: ");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("(a+b)^2 = "+ ((value1*value1)+(2*(value1*value2))+(value2*value2)));

        }
    }
}