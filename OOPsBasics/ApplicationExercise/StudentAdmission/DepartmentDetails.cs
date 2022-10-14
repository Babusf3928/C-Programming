using System;

namespace StudentAdmission
{
    public  class DepartmentDetails
    {
        private static int s_departmentId =100;
        public  string DepartmentID { get;}
        public  string DepartmentName { get; set;}
        public  int NumberOfSeats { get; set;}

        public DepartmentDetails(string departmentName,int numberOfSeats)
        {
            s_departmentId++;
            DepartmentID="DID"+s_departmentId;
            DepartmentName=departmentName;
            NumberOfSeats=numberOfSeats;
        }

        public DepartmentDetails(string data)
        {
            string[] values=data.Split(',');
            s_departmentId=int.Parse(values[0].Remove(0,3));
            DepartmentID=values[0];
            DepartmentName=values[1];
            NumberOfSeats=int.Parse(values[2]);
        }

        
         
    }
}