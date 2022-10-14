using System;
namespace ECommerce;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Operations.DefaultData();
        Files.ReadLine();
        Operations.MainMenu();
        Files.WriteToFiles();
        
    }
}