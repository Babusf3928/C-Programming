using System;
namespace Exercise5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Maths mark: ");
            float maths = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Chemistry mark: ");
            float chem = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Physics mark: ");
            float phy = float.Parse(Console.ReadLine());
            float sum = maths+chem+phy;
            Console.WriteLine("The Sum of the marks is " +sum);
            Console.WriteLine("The Percentage of the marks is " +((sum)/300)*100 +"%");
            
        }
    }
}