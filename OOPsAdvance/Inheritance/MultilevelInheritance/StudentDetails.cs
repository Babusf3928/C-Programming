using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public enum Department{Default,EEE,CSE,ECE}
    public class StudentDetails:PersonalDetails,IMarkDetails
    {
        private static int s_studentId=1000;
        public string StudentID { get; }
        public Department Department { get; set; }
        public string Year { get; set; }

        public int Maths { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }

        public StudentDetails(string aadhar,string name,string fatherName,Gender gender,long phone,Department department,string year):base( aadhar, name, fatherName, gender, phone)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            Year=year;
        }

        public StudentDetails(string studentId,string aadhar,string name,string fatherName,Gender gender,long phone,Department department):base( aadhar, name, fatherName, gender, phone)
        {
            StudentID=studentId;
            Department=department;
            
        }

        public void GetMark(int maths,int physics,int chemistry)
        {
            Maths=maths;
            Physics=physics;
            Chemistry=chemistry;
        }

        public void Calculate()
        {
            Total=Maths+Physics+Chemistry;
            Average=(double)(Total)/3.0;
        }

        public void ShowMark()
        {
            System.Console.WriteLine($"Maths : {Maths}\tPhysics: {Physics}\tChemistry: {Chemistry}");
            System.Console.WriteLine($"Total : {Total}\tAverage: {Average}");
        }

        public void ShowStudent()
        {
            System.Console.WriteLine($"Student ID is {StudentID} ");
            ShowDetails();
            System.Console.WriteLine($"Department is {Department}\nYear is {Year}");
        }

    }
}