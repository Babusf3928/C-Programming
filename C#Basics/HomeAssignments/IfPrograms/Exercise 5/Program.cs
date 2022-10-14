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
            float percent = (sum/300)*100;
            if(percent >= 75)
            {
                Console.WriteLine("The Canditate is eligible for admission ");
            }
            else
            {
                Console.WriteLine("The Canditate is not eligible for admission ");
            }
            



            
        }
    }
}
    

