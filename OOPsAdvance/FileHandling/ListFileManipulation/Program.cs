using System;
using System.Collections.Generic;
using System.IO;
namespace ListFileManipulation;
class Program
{
    public static void Main(string[] args)
    {
        List<StudentDetails> studentList = new List<StudentDetails>();
        studentList.Add(new StudentDetails(){Name="Babu",FatherName="Periyasamy",Gender=Gender.Male,DOB=new DateTime(2001,04,07)});
        studentList.Add(new StudentDetails(){Name="Jose",FatherName="Antony",Gender=Gender.Male,DOB=new DateTime(1999,10,26)});
        studentList.Add(new StudentDetails(){Name="Bala",FatherName="Murugan",Gender=Gender.Male,DOB=new DateTime(2000,07,15)});
        Insert(studentList);
        Display();
    }

    public static void Insert(List<StudentDetails> studentList)
    {
        StreamWriter write = null;
        if(!File.Exists("Data.csv"))
        {
            System.Console.WriteLine("File does not exist . creating new CSV file");
            File.Create("Data.csv");
        }
        else
        {
            System.Console.WriteLine("File Already Exists");
        }
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var v in studentList)
        {
            write.WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.DOB.ToString("dd/MM/yyyy"));
        }
        write.Close();
    }

    public static void Display()
    {
        StreamReader reader = null;
        List<StudentDetails> listA=new List<StudentDetails>();
        if(File.Exists("Data.csv"))
        {
            reader = new StreamReader(File.OpenRead("Data.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if(values[0]!="")
                {
                    listA.Add(new StudentDetails(){Name = values[0],FatherName = values[1],Gender = Enum.Parse<Gender>(values[2]),DOB = DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                }
            }
        }
        else
        {
            System.Console.WriteLine("File doesn't Exist");
        }
        reader.Close();
        foreach(var column1 in listA)
        {
            System.Console.WriteLine($"Your Name:{column1.Name}\tFather Name:{column1.FatherName}\tGender is:{column1.Gender}\tDate of Birth is:{column1.DOB.ToString("dd/MM/yyyy")}"
            );
        }
    }

    
}