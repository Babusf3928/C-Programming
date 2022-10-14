using System;
namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter the number 1 : ");
                int number1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the number 2 : ");
                int number2 = int.Parse(Console.ReadLine());
                int division = number1/number2;
                System.Console.WriteLine(division);
            }
            catch(DivideByZeroException e)
            {
                System.Console.WriteLine("An Exception is occurred : {0}",e.Message);
                System.Console.WriteLine("An Exception is occured : {0}",e.StackTrace);
            }
            catch(FormatException e)
            {
                System.Console.WriteLine(("An Exception is occurred : {0}",e.Message));
                System.Console.WriteLine("An Exception is occurred : {0}",e.StackTrace);
            }
            finally
            {
                System.Console.WriteLine("All Exceptions handled properly");
            }
            
        }
    }
}