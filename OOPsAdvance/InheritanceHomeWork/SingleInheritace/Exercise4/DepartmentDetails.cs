using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise4
{
    public enum Degree{Default,BE,Btech}
    public class DepartmentDetails
    {
        public string DepartmentName { get; set; }
        public Degree Degree{ get; set; }

        public DepartmentDetails(string departmentName,Degree degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }

        public void ShowDepartment()
        {
            System.Console.WriteLine($"Department name is {DepartmentName}\nDegree is {Degree}");
        }
    }
}