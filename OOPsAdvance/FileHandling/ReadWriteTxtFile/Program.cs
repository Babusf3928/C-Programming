using System;
using System.IO;
namespace ReadWriteTxtFile;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder created");
        }
        else
        {
            System.Console.WriteLine("Folder already exists");
        }

        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created");
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }

        System.Console.WriteLine("Select Option 1. Read File Info 2. Write File Info");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader("TestFolder/Test.txt");
                    line = reader.ReadLine();
                    while(line!=null)
                    {
                        System.Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception : "+e.Message);
                }
                finally
                {
                    if(reader !=null)
                    {
                        System.Console.WriteLine("Executing finally block");
                        reader.Close();
                    }
                }
                break;
            }

            case 2:
            {
                
                StreamWriter writer =null;
                try
                {
                    string [] old = File.ReadAllLines("TestFolder/Test.txt");
                    writer = new StreamWriter("TestFolder/Test.txt");
                    System.Console.WriteLine("Enter new lines to add in the file");
                    string add = Console.ReadLine();
                    string old1="";
                    foreach(string text in old)
                    {
                        old1=old1+text+"\n";
                    }
                    old1=old1+add;
                    writer.WriteLine(old1);
                    
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception : "+e.Message);
                }
                finally
                {
                    if(writer != null)
                    {
                        System.Console.WriteLine("Executing finally block");
                        writer.Close();
                    }
                }
                break;
            }
        }
    }
}