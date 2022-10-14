using System;
namespace OnlineMedical;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFiles();
        Operations.MainMenu();
        Files.WriteToFiles();


        
    }
}