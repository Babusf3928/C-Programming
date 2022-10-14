using System;
namespace WhileLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 0 ;
            while(i<=25)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            int value;
            Console.WriteLine("Enter the input: ");
            bool temp = int.TryParse(Console.ReadLine(),out value);
            while(temp == false)
            {
                Console.WriteLine("Invalid input format. Please enter the input in number format.");
                Console.WriteLine("Enter the input: ");
                temp = int.TryParse(Console.ReadLine(),out value);
                

            }
            Console.WriteLine("The input is : "+ value);
        }   
    }
}