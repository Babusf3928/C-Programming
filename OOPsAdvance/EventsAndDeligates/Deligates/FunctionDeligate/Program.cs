using System;
namespace FunctionDeligate;
class Program
{
    static double Sum(int a,int b)  { return a+b;}

    static double Subtract(int a,int b) {return a-b;}

    static double Calculator(Func<int,int,double> operation, int x,int y)
    {
        return operation(x,y);
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine(Calculator(Sum,10,20));
        System.Console.WriteLine(Calculator(Subtract,10,20));
    }
}