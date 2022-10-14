using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
        public void ShowDetails()
        {
            System.Console.WriteLine($"Student name is {Name}\nFather name is {FatherName}\nDate of birth is {DOB.ToString("dd/MM/yyyy",null)}\nStudent gender is {Gender}\nStudent physics mark is {Physics}\nStudent chemistry mark is {Chemistry}\nStudent maths mark is {Maths} ");
            
        }
    }
}