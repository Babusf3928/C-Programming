using System;
namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter the input: ");
            bool temp = int.TryParse(Console.ReadLine(),out value);
            while(temp== false)
            {
                Console.WriteLine("Invalid input. Enter the valid input: ");
                temp = int.TryParse(Console.ReadLine(),out value);
            }
            Console.WriteLine("Valid input");
            if(value >= 1 && value <= 5){
                Console.WriteLine("The number is between the range of 1-5 ");
            }
            else
            {
                Console.WriteLine("The number is not in the range of 1-5");
            }
        }
    }
}
