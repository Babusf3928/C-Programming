using System;
namespace StudentData
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentInfo.ShowDetails();
            StudentInfo.RegisterNumber="SF3922";
            System.Console.WriteLine(StudentInfo.RegisterNumber);
        }
        
    }
}