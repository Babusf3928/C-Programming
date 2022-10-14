using System;
namespace OperatorOverloading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1 = new Box(3,4,2);
        Box box2 = new Box(5,8,6);
        Box box3;
        
        double volume;

        volume = box1.GetVolume();
        System.Console.WriteLine($"The volume of box 1 is {volume}");

        volume = box2.GetVolume();
        System.Console.WriteLine($"The volume of box 2 is {volume}");

        box3 = box1 + box2;
        volume = box3.GetVolume();
        System.Console.WriteLine($"The volume of box 3 is {volume}");
    }
}