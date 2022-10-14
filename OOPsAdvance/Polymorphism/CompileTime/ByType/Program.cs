using System;
namespace ByType;
class Program
{
    static void Display(int number)
    {
        System.Console.WriteLine($"int type : {number}");
    }

    static void Display(string name)
    {
        System.Console.WriteLine($"string type : {name}");
    }
    static void Main(string[] args)
    {
        Display(10);
        Display("Babu");
    }
}