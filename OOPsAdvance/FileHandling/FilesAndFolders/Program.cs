using System;
using System.IO;
namespace FilesAndFolders;
class Program
{
    public static void Main(string[] args)
    {
        string path =@"C:\Users\BabuPeriyasamy\OneDrive - Syncfusion\Desktop\MyFolder";

        string folderPath = path+"/Babu";
        string filePath = path+"/newFile.txt";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found creating folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Directory found");
        }

        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not found creating file");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File Already Exists");
        }

        System.Console.WriteLine("Select option 1.Create Folder 2.Create File 3.Delete Folder 4.Delete File");
        int option = int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Enter folder name you want to create ");
                string name1= Console.ReadLine();
                string newPath=path+"\\"+name1;
                if(!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    System.Console.WriteLine("Directory name already exists");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter file name you want to create");
                string fileName= Console.ReadLine();
                System.Console.WriteLine("Enter file extention you want to create");
                string extention= Console.ReadLine();
                string newPath = path+"\\"+fileName+"."+extention;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else
                {
                    System.Console.WriteLine("File name already exists");
                }
                break;
                
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path) )
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete");
                string name1 = Console.ReadLine();
                string newPath=path+"\\"+name1;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                        try
                        {
                            Directory.Delete(newPath);
                            System.Console.WriteLine("Folder Deleted");
                        }
                        catch(DirectoryNotFoundException e)
                        {
                            System.Console.WriteLine("Directory not found exception "+e.Message);
                        }
                    }
                }
                break;
            }
            case 4: 
            {
                foreach(string name in Directory.GetFiles(path) )
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select file you want to delete");
                string name1 = Console.ReadLine();
                System.Console.WriteLine("Enter the file extension you want to delete");
                string name2 = Console.ReadLine();
                string newPath=path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)
                    {
                        try
                        {
                            File.Delete(newPath);
                            System.Console.WriteLine("File Deleted");
                        }
                        catch(FileNotFoundException e)
                        {
                            System.Console.WriteLine("File not found exception "+e.Message);
                        }
                    }
                }
                break;
            }
        }
    }
}