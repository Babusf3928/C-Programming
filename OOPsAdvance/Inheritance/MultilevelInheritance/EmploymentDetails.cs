using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employmentId=1000;
        public string EmploymentID { get; }
        public DateTime RegisterDate { get; set; }

        public EmploymentDetails(string studentId,string aadhar,string name,string fatherName,Gender gender,long phone,Department department):base(studentId,aadhar,name,fatherName,gender,phone,department)
        {
            s_employmentId++;
            EmploymentID="EID"+s_employmentId;
            RegisterDate=DateTime.Now;
        }

        public void ShowEmploymentDetail()
        {
            System.Console.WriteLine($"Employment ID is {EmploymentID}");
            ShowDetails();
            System.Console.WriteLine($"Registration Date is {RegisterDate.ToString("dd/MM/yyyy")}");
        }
    }
}