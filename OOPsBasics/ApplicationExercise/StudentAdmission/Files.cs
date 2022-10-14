using System;
using System.IO;

namespace StudentAdmission
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/AdmissionDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/DepartmentDetails.csv");
            }

        }

        public static void ReadFile()
        {
            string [] students = File.ReadAllLines("College/StudentDetails.csv");

            foreach(string data in students)
            {
                StudentDetails student = new StudentDetails(data);
                Operations.studentList.Add(student);
            }

            string [] departments = File.ReadAllLines("College/DepartmentDetails.csv");

            foreach(string data in departments)
            {
                DepartmentDetails department = new DepartmentDetails(data);
                Operations.departmentList.Add(department);
            }

            string [] admissions = File.ReadAllLines("College/AdmissionDetails.csv");

            foreach(string data in admissions)
            {
                AdmissionDetails admission = new AdmissionDetails(data);
                Operations.admissionList.Add(admission);
            }
        }

        public static void WriteToFiles()
        {
            string [] studentDetails = new string[Operations.studentList.Count];
            for(int i =0;i<Operations.studentList.Count;i++)
            {
                studentDetails[i]=Operations.studentList[i].StudentID+","+Operations.studentList[i].Name+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.studentList[i].Gender+","+Operations.studentList[i].Physics+","+Operations.studentList[i].Chemistry+","+Operations.studentList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);

            string [] departmentDetails = new string[Operations.departmentList.Count];
            for(int i =0;i<Operations.departmentList.Count;i++)
            {
                departmentDetails[i]=Operations.departmentList[i].DepartmentID+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("College/DepartmentDetails.csv",departmentDetails);

            string [] admissionDetails = new string[Operations.admissionList.Count];
            for(int i =0;i<Operations.admissionList.Count;i++)
            {
                admissionDetails[i]=Operations.admissionList[i].AdmissionID+","+Operations.admissionList[i].StudentID+","+Operations.admissionList[i].DepartmentID+","+Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("College/AdmissionDetails.csv",admissionDetails);
        }
        
    }
}