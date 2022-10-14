using System;
namespace Interface;
class Program
{
    public static void Main(string[] args)
    {
        Draw area1=new Draw();
        area1.GetValue(5,4);
        area1.CalculateArea();
    }
}