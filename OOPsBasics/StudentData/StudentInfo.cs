using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData
{
    public static class StudentInfo
    {
        public static string RegisterNumber;
        public static string Name { get; set; }
        

        static StudentInfo()
        {
            RegisterNumber="SF3928";
            Name="Babu";
        }
        public  static void ShowDetails()
        {
            System.Console.WriteLine("Your name is "+Name);
            System.Console.WriteLine("Your Register Number is "+RegisterNumber);
        
        }



    }
}