using System;
namespace MethodForPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            string condition;

            do
            {
                Console.WriteLine("Choose the given option to perform the respective Arithmetic operation: \n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
                int option = int.Parse(Console.ReadLine());
               
                
                switch(option)
                {
                    case 1:
                    { 
                        Console.WriteLine("Enter the number 1 : ");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number 2 : ");
                        int number2 = int.Parse(Console.ReadLine());
                        int sum = Addition( number1,  number2);
                        Console.WriteLine("Addition:"+sum);
                        break;
                    }
                    case 2:
                    { 
                        Console.WriteLine("Enter the number 1 : ");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number 2 : ");
                        int number2 = int.Parse(Console.ReadLine());
                        Subtraction(number1, number2);
                        break;
                    }
                    case 3:
                    {
                        int multiplication =Multiplication();
                        Console.WriteLine(multiplication);
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Division:");
                        Division();
                        break;
                    }
                }
                Console.WriteLine("Do you want to continue ? Enter 'Yes' or 'No'");
                condition = Console.ReadLine().ToLower();
                if(condition != "yes" && condition != "no")
                {
                    Console.WriteLine("You have entered the invalid input");
                }
            }while(condition =="yes");
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
                Console.WriteLine("Enter the number 1 : ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number 2 : ");
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Multiplication of the given numbers is:");
                int multiplication = number1 * number2;
                return multiplication;
            }
            void Division()
            {
                Console.WriteLine("Enter the number 1 : ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number 2 : ");
                int number2 = int.Parse(Console.ReadLine());
                int division = number1 / number2;
                Console.WriteLine("The Division of the given numbers is :"+division);
            }

        }   
    }
}