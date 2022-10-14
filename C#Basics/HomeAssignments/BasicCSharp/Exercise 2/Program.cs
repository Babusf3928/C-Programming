using System;
namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            int addition = num1+num2;
            int subtraction = num1-num2;
            int multiplication = num1*num2;
            int division = num1/num2;
            int modulus = num1%num2;
            Console.WriteLine(num1 + " + "+num2 +" = "+ addition);
            Console.WriteLine(num1 + " - "+num2 +" = "+ subtraction);
            Console.WriteLine(num1 + " * "+num2 +" = "+ multiplication);
            Console.WriteLine(num1 + " / "+num2 +" = "+ division);
            Console.WriteLine(num1 + " % "+num2 +" = "+ modulus);
        }
    }
}