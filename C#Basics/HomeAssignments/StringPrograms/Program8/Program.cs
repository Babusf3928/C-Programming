using System;
namespace Program8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string : ");
        string word = Console.ReadLine();
        System.Console.WriteLine("Input the position to extract :");
        int position = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the end position to stop:");
        int end = int.Parse(Console.ReadLine())+position;
        for(int i =position;i<end;i++)
        {
            System.Console.Write(word[i]);
        }

    }
}