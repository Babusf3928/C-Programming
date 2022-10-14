using System;
namespace ListDS;
class Program
{
    public static void Main(string[] args)
    {
        List<int> datas = new List<int>();
        datas.AddElement(19);
        datas.AddElement(6);
        datas.AddElement(5);
        datas.AddElement(56);
        datas.AddElement(54);
        datas.Insert(3,45);
        datas.RemoveAt(4);
        datas.Remove(56);

        foreach(var number in datas)
        {
            System.Console.WriteLine(number);
        }

        System.Console.WriteLine("\n");

        for(int i=0;i<datas.Count;i++)
        {
            System.Console.WriteLine(datas[i]);
        }
    }
}