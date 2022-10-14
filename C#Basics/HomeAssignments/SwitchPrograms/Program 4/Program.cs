using System;
namespace Program4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1 : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2 : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please press the correct choice to perform the Arithmetic Operation that you needed.Press '1' for Addition,'2' for Subtraction,'3' for Multiplication , '4' for Division , '5' for Exit ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine("The addition of the given numbers is "+(number1+number2));
                    break;
                }
                case 2:
                {
                    Console.WriteLine("The Subtraction of the given numbers is "+(number1-number2));
                    break;
                }
                case 3:
                {
                    Console.WriteLine("The Multiplication of the given numbers is "+(number1*number2));
                    break;
                }
                case 4:
                {
                    Console.WriteLine("The division of the given numbers is "+(number1/number2));
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Exit");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Option");
                    break;
                }

            }
        }
    }
}