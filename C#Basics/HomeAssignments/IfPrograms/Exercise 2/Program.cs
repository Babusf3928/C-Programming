using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if(age > 18)
            {
                Console.WriteLine("Congratulations! \nYou are eligible for casting your vote");
            }
            else
            {
                Console.WriteLine("You are not eligible for casting your vote");
            }
        }
    }
}
