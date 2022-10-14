using System;
namespace SwitchCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1 : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2 : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please press the correct choice to perform the Arithmetic Operation that you needed.Press '+' for Addition,'-' for Subtraction,'*' for Multiplication , '/' for Division , '%' for Modulus ");
            char choice = char.Parse(Console.ReadLine());
            switch(choice)
            {
                case '+':
                {
                    Console.WriteLine("The addition of the given numbers is "+(number1+number2));
                    break;
                }
                case '-':
                {
                    Console.WriteLine("The Subtraction of the given numbers is "+(number1-number2));
                    break;
                }
                case '*':
                {
                    Console.WriteLine("The Multiplication of the given numbers is "+(number1*number2));
                    break;
                }
                case '/':
                {
                    Console.WriteLine("The division of the given numbers is "+(number1/number2));
                    break;
                }
                case '%':
                {
                    Console.WriteLine("The Modulus of the given numbers is "+(number1%number2));
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Operation");
                    break;
                }

            }
        }
    }
}