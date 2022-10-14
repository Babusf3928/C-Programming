using System;
namespace SingleCastingDeligate;

    public delegate int Calculator(int number);
class Program
{

    static int value = 10;

    public static int AddNumber(int number) { value = value+number; return value;}

    public static int MultNumber(int number) { value*=number; return value;}

    public static int GetNumber() {return value;}
    public static void Main(string[] args)
    {
        Calculator number1 = new Calculator(AddNumber);
        Calculator number2 = new Calculator(MultNumber);

        number1(3);

        System.Console.WriteLine($"Value of number is {GetNumber()}");

        number2(2);

        System.Console.WriteLine($"value of number is {GetNumber()}");
    }
}