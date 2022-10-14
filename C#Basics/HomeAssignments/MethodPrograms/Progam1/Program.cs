using System;
namespace Program1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1 : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number 2 : ");
            int number2 = int.Parse(Console.ReadLine());
            int sum = Addition( number1,  number2);
            Console.WriteLine("Addition:"+sum);
            Subtraction(number1, number2);
            int multiplication =Multiplication();
            Console.WriteLine(multiplication);
            Division();
            int Addition(int value1,int value2)
            {
                int sum ;
                sum = value1 + value2;
                return sum;
            }
            void Subtraction(int value1,int value2)
            {
                int difference = value1 - value2;
                Console.WriteLine("The Subtraction of the given numbers is :"+difference);
            }
            int Multiplication()
            {
                Console.WriteLine("Multiplication of the given numbers is:");
                int multiplication = number1 * number2;
                return multiplication;
            }
            void Division()
            {
                int division = number1 / number2;
                Console.WriteLine("The Division of the given numbers is :"+division);
            }

        }   
    }
}